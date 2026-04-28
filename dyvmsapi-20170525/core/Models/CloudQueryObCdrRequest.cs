// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryObCdrRequest : TeaModel {
        /// <summary>
        /// <para>座席姓名</para>
        /// 
        /// <b>Example:</b>
        /// <para>name3</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>座席号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>41008502</para>
        /// </summary>
        [NameInMap("AgentNumber")]
        [Validation(Required=false)]
        public string AgentNumber { get; set; }

        /// <summary>
        /// <para>呼叫类型；为空表示全部，可选值为：4:预览外呼 6:主叫外呼 9:内部呼叫</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CallType")]
        [Validation(Required=false)]
        public long? CallType { get; set; }

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
        /// <para>客户侧外显号码过滤条件</para>
        /// 
        /// <b>Example:</b>
        /// <para>4100</para>
        /// </summary>
        [NameInMap("Clid")]
        [Validation(Required=false)]
        public string Clid { get; set; }

        /// <summary>
        /// <para>座席工号，单个座席工号3-10位，支持一个或多个座席工号查询，多个座席工号以英文逗号隔开，一次最多支持100个。不支持模糊匹配。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

        /// <summary>
        /// <para>客户号码，支持一个或多个客户号码查询，多个客户号码以英文逗号隔开，一次最多支持100个。不支持模糊匹配。</para>
        /// 
        /// <b>Example:</b>
        /// <para>13322223333</para>
        /// </summary>
        [NameInMap("CustomerNumber")]
        [Validation(Required=false)]
        public string CustomerNumber { get; set; }

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
        /// <para>座席所属外呼组 单个外呼组号2-20位，支持一个或多个座席工号查询，多个座席工号以英文逗号隔开，一次最多支持10个。不支持模糊匹配。</para>
        /// 
        /// <b>Example:</b>
        /// <para>455</para>
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
        /// <para>客户侧真实外显号码过滤条件，当使用虚拟号进行AXB外呼且开关打开时，实际过滤的客户侧真实外显号码是虚拟号</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("LeftDisplayNumber")]
        [Validation(Required=false)]
        public string LeftDisplayNumber { get; set; }

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
        /// <para>排序方式；取值说明：0: 按照记录产生的时序顺序排序，1：按照记录产生的时序逆序排序，2: 按照结束时间的时序顺序排序，3：按照结束时间的时序逆序排序</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        /// <summary>
        /// <para>客户电话归属省份；为空表示全部，如&quot;四川&quot;，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>查询请求唯一id对应的记录信息，默认查询当前月，如requestUniqueId不属于当前月，查询时请传递查询参数 查询开始时间(startTime)</para>
        /// 
        /// <b>Example:</b>
        /// <para>req_uniq_1-162046xxxx.12</para>
        /// </summary>
        [NameInMap("RequestUniqueId")]
        [Validation(Required=false)]
        public string RequestUniqueId { get; set; }

        /// <summary>
        /// <para>是否返回总条数；取值说明：0: 不返回，1：返回，不传默认为1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnCount")]
        [Validation(Required=false)]
        public long? ReturnCount { get; set; }

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
        /// <para>呼叫结果；参数说明：30 座席未接听; 31 座席接听,未呼叫客户; 32 座席接听,客户未接听; 33 双方接听; 50 主叫外呼接听; 51 主叫外呼,客户未接听; 52 主叫外呼,双方接听。</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
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
        /// <para>用户自定义参数指定查询value；传递该参数时必须传递userFieldKey，仅查询一个字段，不支持模糊匹配，构造的自定义字段查询条件为:{&quot;userFieldkey&quot;:&quot;userFieldvalue&quot;}，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userFieldkey&quot;:&quot;userFieldvalue&quot;}</para>
        /// </summary>
        [NameInMap("UserFieldValue")]
        [Validation(Required=false)]
        public string UserFieldValue { get; set; }

        /// <summary>
        /// <para>用户自定义参数指定查询key；传递该参数时必须传递userFieldValue，仅查询一个字段，不支持模糊匹配，构造的自定义字段查询条件为:{&quot;userFieldkey&quot;:&quot;userFieldvalue&quot;}，此参数需要URLEncode</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userFieldkey&quot;:&quot;userFieldvalue&quot;}</para>
        /// </summary>
        [NameInMap("UserFieldkey")]
        [Validation(Required=false)]
        public string UserFieldkey { get; set; }

    }

}
