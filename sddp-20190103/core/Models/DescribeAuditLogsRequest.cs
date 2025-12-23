// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeAuditLogsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CE4681BA-8019-5BE1-9F4B-8973BEA9CF57</para>
        /// </summary>
        [NameInMap("AsyncRequestId")]
        [Validation(Required=false)]
        public string AsyncRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.<em>.</em>.94</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("ClientUa")]
        [Validation(Required=false)]
        public string ClientUa { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bose_o2o_data</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>in[1 33]</para>
        /// </summary>
        [NameInMap("EffectRowRange")]
        [Validation(Required=false)]
        public string EffectRowRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1583856000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>in[1000 2000]</para>
        /// </summary>
        [NameInMap("ExecuteTimeRange")]
        [Validation(Required=false)]
        public string ExecuteTimeRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-2zeftaaq4gqcqb9kfkzg</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LoadWhiteList")]
        [Validation(Required=false)]
        public bool? LoadWhiteList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[ {   &quot;isContain&quot; : false,   &quot;queryKey&quot; : &quot;effectRowRange&quot; }, {   &quot;isContain&quot; : false,   &quot;queryKey&quot; : &quot;remoteClientIp&quot; } ]</para>
        /// </summary>
        [NameInMap("LogQueryOpJson")]
        [Validation(Required=false)]
        public string LogQueryOpJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SLOW_SQL</para>
        /// </summary>
        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public string MemberAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Insert</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-key</para>
        /// </summary>
        [NameInMap("OssObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("RuleAggQuery")]
        [Validation(Required=false)]
        public bool? RuleAggQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RuleCategory")]
        [Validation(Required=false)]
        public string RuleCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>994007</para>
        /// </summary>
        [NameInMap("RuleID")]
        [Validation(Required=false)]
        public string RuleID { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>select * from test03</para>
        /// </summary>
        [NameInMap("SqlText")]
        [Validation(Required=false)]
        public string SqlText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1616068534877</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
