// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListCdrIbRequest : TeaModel {
        /// <summary>
        /// <para>通话时长范围查询最小值，和bridgeDurationEnd配合使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("BridgeDuration")]
        [Validation(Required=false)]
        public long? BridgeDuration { get; set; }

        /// <summary>
        /// <para>通话时长范围查询最大值</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("BridgeDurationEnd")]
        [Validation(Required=false)]
        public long? BridgeDurationEnd { get; set; }

        /// <summary>
        /// <para>接听时间，时间戳格式精确到秒。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("BridgeTime")]
        [Validation(Required=false)]
        public long? BridgeTime { get; set; }

        /// <summary>
        /// <para>接听时间查询截止，时间戳格式精确到秒。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("BridgeTimeEnd")]
        [Validation(Required=false)]
        public long? BridgeTimeEnd { get; set; }

        /// <summary>
        /// <para>座席电话</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ClientNumber")]
        [Validation(Required=false)]
        public string ClientNumber { get; set; }

        /// <summary>
        /// <para>座席号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cnos")]
        [Validation(Required=false)]
        public string Cnos { get; set; }

        /// <summary>
        /// <para>客户号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("CustomerNumber")]
        [Validation(Required=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// <para>结束时间，时间戳格式精确到秒。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>结束时间查询截止，时间戳格式精确到秒。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public long? EndTimeEnd { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8004970</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>首呼座席</para>
        /// 
        /// <b>Example:</b>
        /// <para>1122</para>
        /// </summary>
        [NameInMap("FirstCallCno")]
        [Validation(Required=false)]
        public string FirstCallCno { get; set; }

        /// <summary>
        /// <para>首呼座席电话</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("FirstCallNumber")]
        [Validation(Required=false)]
        public string FirstCallNumber { get; set; }

        /// <summary>
        /// <para>首呼队列</para>
        /// 
        /// <b>Example:</b>
        /// <para>2222</para>
        /// </summary>
        [NameInMap("FirstCallQno")]
        [Validation(Required=false)]
        public string FirstCallQno { get; set; }

        /// <summary>
        /// <para>是否隐藏号码。  0: 不隐藏，1: 中间四位，2: 最后八位，3: 全部号码，4: 最后四位。默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HiddenType")]
        [Validation(Required=false)]
        public long? HiddenType { get; set; }

        /// <summary>
        /// <para>查询条数，范围 10-100。默认值为 10。注：limit + offset 不允许超过100000</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>通话记录唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>uniq_1-162046xxxx.12</para>
        /// </summary>
        [NameInMap("MainUniqueId")]
        [Validation(Required=false)]
        public string MainUniqueId { get; set; }

        /// <summary>
        /// <para>偏移量，范围 0-99990。默认值为 0。注：limit + offset 不允许超过100000</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>队列号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1122</para>
        /// </summary>
        [NameInMap("Qnos")]
        [Validation(Required=false)]
        public string Qnos { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>滚动查询ID。配合scrollSearch使用，第一次查询时不需要传递此参数，后续查询可从返回列表中取值，并传参数。当scrollId为空时，代表滚动查询结束。</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ScrollId")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// <para>是否滚动查询。默认false，true代表使用滚动查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ScrollSearch")]
        [Validation(Required=false)]
        public string ScrollSearch { get; set; }

        /// <summary>
        /// <para>开始时间，时间戳格式精确到秒。默认值取当前月份第一天</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>开始时间查询截止，时间戳格式精确到秒，开始时间和结束时间跨度不能超过一个月。默认值取当前时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("StartTimeEnd")]
        [Validation(Required=false)]
        public long? StartTimeEnd { get; set; }

        /// <summary>
        /// <para>接听状态。取值范围如下：  1: 人工接听  2: 人工未接听  3: 系统应答  4: 系统未应答  默认全部</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public long? Statuses { get; set; }

        /// <summary>
        /// <para>总时长范围查询最小值，和totalDurationEnd配合使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>69</para>
        /// </summary>
        [NameInMap("TotalDuration")]
        [Validation(Required=false)]
        public long? TotalDuration { get; set; }

        /// <summary>
        /// <para>总时长范围查询最大值</para>
        /// 
        /// <b>Example:</b>
        /// <para>47</para>
        /// </summary>
        [NameInMap("TotalDurationEnd")]
        [Validation(Required=false)]
        public long? TotalDurationEnd { get; set; }

    }

}
