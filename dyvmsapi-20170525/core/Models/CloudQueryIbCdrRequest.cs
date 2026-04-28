// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryIbCdrRequest : TeaModel {
        /// <summary>
        /// <para>座席号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>41008502</para>
        /// </summary>
        [NameInMap("CalleeNumber")]
        [Validation(Required=false)]
        public string CalleeNumber { get; set; }

        /// <summary>
        /// <para>客户电话归属城市；为空表示全部，如&quot;成都&quot;，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>座席工号,此字段支持传入多个座席工号，使用英文半角逗号隔开</para>
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
        /// <para>17750247753</para>
        /// </summary>
        [NameInMap("CustomerNumber")]
        [Validation(Required=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// <para>查询结束时间；时间戳格式,精确到s。startTime与endTime不允许跨月，默认值取当前月份最后一天</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775030413</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>热线号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>10003221</para>
        /// </summary>
        [NameInMap("Hotline")]
        [Validation(Required=false)]
        public string Hotline { get; set; }

        /// <summary>
        /// <para>未进入队列原因 参数说明： 4: 无座席未进入队列 , 3: 队列满未进入队列</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("JoinQueueCode")]
        [Validation(Required=false)]
        public long? JoinQueueCode { get; set; }

        /// <summary>
        /// <para>离开队列原因 参数说明： 2: 队列中放弃 , 3: 队列中超时溢出 , 4: 队列中无座席溢出</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LeaveQueueCode")]
        [Validation(Required=false)]
        public long? LeaveQueueCode { get; set; }

        /// <summary>
        /// <para>需要取出的数据条数；大于0，最大不能超过1000，默认10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>客户电话归属省份；为空表示全部，如&quot;四川&quot;，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>队列号 参数说明：-1: 未进入队列</para>
        /// 
        /// <b>Example:</b>
        /// <para>566</para>
        /// </summary>
        [NameInMap("Qno")]
        [Validation(Required=false)]
        public string Qno { get; set; }

        /// <summary>
        /// <para>从第几条开始取；大于等于0，默认0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>查询开始时间；时间戳格式,精确到s。startTime与endTime不允许跨月，默认值取当前月份第一天</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>呼叫结果；参数说明： 1:座席接听 2:已呼叫座席，座席未接听 3:系统接听 4:系统未接听-IVR配置错误 5:系统未接听-停机 6:系统未接听-欠费 7:系统未接听-黑名单 8:系统未接听-未注册 9:系统未接听-彩铃 11:系统未接听-呼叫超出营帐中设置的最大限制 12:系统未接听-客户呼入系统后在系统未应答前挂机 13:其他错误 14:未进入队列 15:队列中放弃 16:队列中超时溢出 17:队列中无座席溢出 18:无座席未进入队列 19:队列满未进入队列</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>查询时间开始结束范围生效类型；通话记录startTime和endTime时间范围生效类型，当startTime和endTime不为空时生效；取值：1.呼叫开始时间 2.呼叫结束时间； 默认为1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeRangeType")]
        [Validation(Required=false)]
        public string TimeRangeType { get; set; }

        /// <summary>
        /// <para>如果uniqueId值不为空，则以下其它参数无效，即仅查询电话唯一标识为uniqueId的记录信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>uniq_1-162046xxxx.12</para>
        /// </summary>
        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// <para>用户自定义参数指定查询value；传递该参数时必须传递userFieldKey，仅查询一个字段，不支持模糊匹配， 构造的自定义字段查询条件为:{&quot;userFieldkey&quot;:&quot;userFieldvalue&quot;}，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>userFieldvalue</para>
        /// </summary>
        [NameInMap("UserFieldValue")]
        [Validation(Required=false)]
        public string UserFieldValue { get; set; }

        /// <summary>
        /// <para>用户自定义参数指定查询key；传递该参数时必须传递userFieldValue，仅查询一个字段，不支持模糊匹配， 构造的自定义字段查询条件为:{&quot;userFieldkey&quot;:&quot;userFieldvalue&quot;}，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>userFieldkey</para>
        /// </summary>
        [NameInMap("UserFieldkey")]
        [Validation(Required=false)]
        public string UserFieldkey { get; set; }

    }

}
