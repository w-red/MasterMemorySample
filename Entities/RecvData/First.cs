using MasterMemory;
using MessagePack;

namespace MasterMemorySample.Entities.RecvData;

[MemoryTable("FirstTable"), MessagePackObject(true)]
public record First
{
    /// <summary>伝票番号</summary>
    [PrimaryKey]
    public required int SlipNo { get; init; }
    /// <summary>便名</summary>
    [NonUnique]
    public int? DeliveryNo { get; init; }
    /// <summary>仕入先</summary>
    [NonUnique]
    public string? SupplierCode { get; init; }
    /// <summary>伝票枝番</summary>
    [NonUnique]
    public int? SeqNo { get; init; }
    /// <summary>商品コード[JAN]</summary>
    [SecondaryKey(0), NonUnique]
    public string? JanCode { get; init; }
    /// <summary>予定数</summary>
    [NonUnique]
    public int? PlannedAmount { get; init; }

    /// <summary>検品状態</summary>
    /// <remarks>0:未、1:済、2:選択</remarks>
    [NonUnique]
    public byte InspectStatus { get; init; }
}
