// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleReShopItemListSubItemsRefundChangeRuleOfferPenaltyInfoMapValue : TeaModel {
        /// <summary>
        /// <para>是否适用规则</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("struct")]
        [Validation(Required=false)]
        public bool? Struct { get; set; }

        /// <summary>
        /// <para>支持退票</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("cancel_fee_ind")]
        [Validation(Required=false)]
        public bool? CancelFeeInd { get; set; }

        /// <summary>
        /// <para>支持改期</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("change_fee_ind")]
        [Validation(Required=false)]
        public bool? ChangeFeeInd { get; set; }

        /// <summary>
        /// <para>支持升舱</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("upgrade_fee_ind")]
        [Validation(Required=false)]
        public bool? UpgradeFeeInd { get; set; }

        /// <summary>
        /// <para>支持换开</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reissue_ind")]
        [Validation(Required=false)]
        public bool? ReissueInd { get; set; }

        /// <summary>
        /// <para>规则类型</para>
        /// <list type="bullet">
        /// <item><description><para>0退票费用</para>
        /// </description></item>
        /// <item><description><para>1改期费用</para>
        /// </description></item>
        /// <item><description><para>2误机罚金</para>
        /// </description></item>
        /// <item><description><para>3其它</para>
        /// </description></item>
        /// <item><description><para>4升舱费用</para>
        /// </description></item>
        /// <item><description><para>5签转</para>
        /// </description></item>
        /// <item><description><para>6已使用航段扣减金额</para>
        /// </description></item>
        /// <item><description><para>100退税</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("penalty_type_code")]
        [Validation(Required=false)]
        public int? PenaltyTypeCode { get; set; }

        /// <summary>
        /// <para>规则的适用范围</para>
        /// <list type="bullet">
        /// <item><description>1全部未使用</description></item>
        /// <item><description>2部分未使用</description></item>
        /// <item><description>3去程</description></item>
        /// <item><description>4回程</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("penalty_apply_range_code")]
        [Validation(Required=false)]
        public int? PenaltyApplyRangeCode { get; set; }

        /// <summary>
        /// <para>规则的收费方式</para>
        /// <list type="bullet">
        /// <item><description>0按照全程收费</description></item>
        /// <item><description>1按每个方向收费</description></item>
        /// <item><description>2按照每个航段收费&quot;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("penalty_charge_type_code")]
        [Validation(Required=false)]
        public int? PenaltyChargeTypeCode { get; set; }

        /// <summary>
        /// <para>费用</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("fee")]
        [Validation(Required=false)]
        public double? Fee { get; set; }

        /// <summary>
        /// <para>费用币种</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>费用百分比</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("penalty_percent")]
        [Validation(Required=false)]
        public double? PenaltyPercent { get; set; }

        /// <summary>
        /// <para>规则时间范围-开始时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>-720</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>规则时间范围-结束时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>-168</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>时间单位</para>
        /// <list type="bullet">
        /// <item><description><para>0小时</para>
        /// </description></item>
        /// <item><description><para>1天</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("time_unit_code")]
        [Validation(Required=false)]
        public int? TimeUnitCode { get; set; }

        /// <summary>
        /// <para>规则标题</para>
        /// 
        /// <b>Example:</b>
        /// <para>退票费用</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>起飞时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-01 01:00:00</para>
        /// </summary>
        [NameInMap("dep_time")]
        [Validation(Required=false)]
        public string DepTime { get; set; }

        /// <summary>
        /// <para>航段序号，</para>
        /// <list type="bullet">
        /// <item><description><para>OUTBOUND_FIRST(&quot;去程第一段&quot;)</para>
        /// </description></item>
        /// <item><description><para>OUTBOUND_SECOND(&quot;去程第二段&quot;)</para>
        /// </description></item>
        /// <item><description><para>INBOUND_FIRST(&quot;回程第一段&quot;)</para>
        /// </description></item>
        /// <item><description><para>INBOUND_SECOND(&quot;回程第二段&quot;)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OUTBOUND_FIRST</para>
        /// </summary>
        [NameInMap("segment_number")]
        [Validation(Required=false)]
        public string SegmentNumber { get; set; }

        /// <summary>
        /// <para>各类非结构化补充说明</para>
        /// </summary>
        [NameInMap("desc_infos")]
        [Validation(Required=false)]
        public Dictionary<string, string> DescInfos { get; set; }

    }

}
