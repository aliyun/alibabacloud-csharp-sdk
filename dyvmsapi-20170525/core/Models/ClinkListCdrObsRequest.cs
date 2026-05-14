// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListCdrObsRequest : TeaModel {
        /// <summary>
        /// <para>业务ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>AssociatedId</para>
        /// </summary>
        [NameInMap("AssociatedId")]
        [Validation(Required=false)]
        public long? AssociatedId { get; set; }

        /// <summary>
        /// <para>客户城市</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

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
        /// <para>座席号，要求只能是 4-11 位数字</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

        /// <summary>
        /// <para>客户号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>177xxxx</para>
        /// </summary>
        [NameInMap("CustomerNumber")]
        [Validation(Required=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// <para>结束时间，时间戳格式精确到秒，开始时间和结束时间跨度不能超过一个月。默认值取当前时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

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
        /// <para>是否邀评: 0: 否 1: 是 2: -</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Evaluation")]
        [Validation(Required=false)]
        public long? Evaluation { get; set; }

        /// <summary>
        /// <para>是否隐藏号码。 0: 不隐藏，1: 中间四位，2: 最后八位 3: 全部号码，4: 最后四位。默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HiddenType")]
        [Validation(Required=false)]
        public long? HiddenType { get; set; }

        /// <summary>
        /// <para>热线号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hotline</para>
        /// </summary>
        [NameInMap("Hotline")]
        [Validation(Required=false)]
        public string Hotline { get; set; }

        /// <summary>
        /// <para>业务ID类型，1：工单；2：业务记录</para>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("IdType")]
        [Validation(Required=false)]
        public long? IdType { get; set; }

        /// <summary>
        /// <para>查询条数，范围 10-100。默认值为 10。注：limit + offset 不允许超过100000</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>通话记录唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>MainUniqueId</para>
        /// </summary>
        [NameInMap("MainUniqueId")]
        [Validation(Required=false)]
        public string MainUniqueId { get; set; }

        /// <summary>
        /// <para>标记。取值范围如下： 为空表示全部， 1:留言 2:转移 3:咨询 4:三方 5:传真接收 6:会议 7:交互 8:IVR中放弃 9:已进入IVR 10:未进入IVR 11:队列中放弃 12:队列中溢出 注： 其中mark值2,3,4,7仅在status=1(座席接听)时有效， mark值1,5,6,8,9,10,11,12在status=3(系统接听)时有效</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Mark")]
        [Validation(Required=false)]
        public long? Mark { get; set; }

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
        /// <para>客户省份</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>队列及时应答: 0: 否 1: 是 2: -</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("QueueAnswerInTime")]
        [Validation(Required=false)]
        public long? QueueAnswerInTime { get; set; }

        /// <summary>
        /// <para>请求唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>RequestUniqueId</para>
        /// </summary>
        [NameInMap("RequestUniqueId")]
        [Validation(Required=false)]
        public string RequestUniqueId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

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
        /// <para>接听状态。取值范围如下： 0: 全部 1: 客户未接听 2: 座席未接听 3: 双方接听 默认值为0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
