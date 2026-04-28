// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryPredictiveCallCdrRequest : TeaModel {
        /// <summary>
        /// <para>座席姓名</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>客户电话归属城市；为空表示全部，如&quot;成都&quot;，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>外显号码；外显的号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>02138276106</para>
        /// </summary>
        [NameInMap("Clid")]
        [Validation(Required=false)]
        public string Clid { get; set; }

        /// <summary>
        /// <para>座席工号，3-10位数字</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

        /// <summary>
        /// <para>客户电话；客户号码，如：18012345678</para>
        /// 
        /// <b>Example:</b>
        /// <para>18012345678</para>
        /// </summary>
        [NameInMap("CustomerNumber")]
        [Validation(Required=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// <para>客户侧真实外显号码，当使用AXB场景进行外呼时，客户侧的真实外显号码为虚拟号</para>
        /// 
        /// <b>Example:</b>
        /// <para>02138276106</para>
        /// </summary>
        [NameInMap("DisplayNumber")]
        [Validation(Required=false)]
        public string DisplayNumber { get; set; }

        /// <summary>
        /// <para>是否呼叫降级；0-否, 1-是</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DownGrade")]
        [Validation(Required=false)]
        public long? DownGrade { get; set; }

        /// <summary>
        /// <para>查询结束时间；时间戳格式,精确到s。startTime与endTime不允许跨月，默认值取当前月份最后一天</para>
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
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>座席所属外呼组 单个外呼组号2-20位，支持一个或多个座席工号查询，多个座席工号以英文逗号隔开，一次最多支持10个。不支持模糊匹配。</para>
        /// 
        /// <b>Example:</b>
        /// <para>WH13</para>
        /// </summary>
        [NameInMap("Gno")]
        [Validation(Required=false)]
        public string Gno { get; set; }

        /// <summary>
        /// <para>真人接听；取值说明：1-是、0-否</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsRealAnswer")]
        [Validation(Required=false)]
        public long? IsRealAnswer { get; set; }

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
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>查询请求唯一id对应的记录信息，默认查询当前月，如requestUniqueId不属于当前月，查询时请传递查询参数 查询开始时间(startTime)</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-uniq_1-162046xxxx.12</para>
        /// </summary>
        [NameInMap("RequestUniqueId")]
        [Validation(Required=false)]
        public string RequestUniqueId { get; set; }

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
        /// <para>呼叫结果；参数说明：40:预测外呼, 客户未接听； 41:预测外呼, 客户接听； 42: 预测外呼,已呼叫； 43: 预测外呼, 双方接听</para>
        /// 
        /// <b>Example:</b>
        /// <para>41</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>批次id</para>
        /// 
        /// <b>Example:</b>
        /// <para>133</para>
        /// </summary>
        [NameInMap("TaskFileId")]
        [Validation(Required=false)]
        public long? TaskFileId { get; set; }

        /// <summary>
        /// <para>外呼任务id</para>
        /// 
        /// <b>Example:</b>
        /// <para>31111</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

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
        /// <para>用户自定义参数指定查询value；传递该参数时必须传递userFieldKey，仅查询一个字段，不支持模糊匹配，构造的自定义字段查询条件为:{&quot;userFieldkey&quot;:&quot;userFieldvalue&quot;}，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>userFieldvalue</para>
        /// </summary>
        [NameInMap("UserFieldValue")]
        [Validation(Required=false)]
        public string UserFieldValue { get; set; }

        /// <summary>
        /// <para>用户自定义参数指定查询key；传递该参数时必须传递userFieldValue，仅查询一个字段，不支持模糊匹配，构造的自定义字段查询条件为:{&quot;userFieldkey&quot;:&quot;userFieldvalue&quot;}，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>userFieldkey</para>
        /// </summary>
        [NameInMap("UserFieldkey")]
        [Validation(Required=false)]
        public string UserFieldkey { get; set; }

    }

}
