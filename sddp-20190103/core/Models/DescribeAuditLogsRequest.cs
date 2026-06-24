// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeAuditLogsRequest : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE4681BA-8019-5BE1-9F4B-8973BEA9CF57</para>
        /// </summary>
        [NameInMap("AsyncRequestId")]
        [Validation(Required=false)]
        public string AsyncRequestId { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.<em>.</em>.94</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The client type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("ClientUa")]
        [Validation(Required=false)]
        public string ClientUa { get; set; }

        /// <summary>
        /// <para>The page number to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bose_o2o_data</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The range of affected rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in[1 33]</para>
        /// </summary>
        [NameInMap("EffectRowRange")]
        [Validation(Required=false)]
        public string EffectRowRange { get; set; }

        /// <summary>
        /// <para>The end time for querying alert logs, provided as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583856000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The execution time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in[1000 2000]</para>
        /// </summary>
        [NameInMap("ExecuteTimeRange")]
        [Validation(Required=false)]
        public string ExecuteTimeRange { get; set; }

        /// <summary>
        /// <para>The name of the data asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zeftaaq4gqcqb9kfkzg</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>default</b>: The IP address is from outside of Alibaba Cloud. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>aliyun</b>: The IP address is from within Alibaba Cloud.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// <para>Specifies the language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the whitelist status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LoadWhiteList")]
        [Validation(Required=false)]
        public bool? LoadWhiteList { get; set; }

        /// <summary>
        /// <para>A JSON string that specifies which query conditions to include or exclude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ {   &quot;isContain&quot; : false,   &quot;queryKey&quot; : &quot;effectRowRange&quot; }, {   &quot;isContain&quot; : false,   &quot;queryKey&quot; : &quot;remoteClientIp&quot; } ]</para>
        /// </summary>
        [NameInMap("LogQueryOpJson")]
        [Validation(Required=false)]
        public string LogQueryOpJson { get; set; }

        /// <summary>
        /// <para>The data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLOW_SQL</para>
        /// </summary>
        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// <para>The UID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public string MemberAccount { get; set; }

        /// <summary>
        /// <para>The message content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The operation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Insert</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The key of the OSS object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-key</para>
        /// </summary>
        [NameInMap("OssObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The service to which the data asset belongs. Valid values include <b>MaxCompute, OSS, AnalyticDB for MySQL, TableStore, and RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the data object belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: OSS</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: AnalyticDB for MySQL</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: TableStore</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: SELF_DB</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: PolarDB-X</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: PolarDB</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: AnalyticDB for PostgreSQL</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: OceanBase</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: MongoDB</para>
        /// </description></item>
        /// <item><description><para><b>25</b>: Redis</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform an aggregate query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RuleAggQuery")]
        [Validation(Required=false)]
        public bool? RuleAggQuery { get; set; }

        /// <summary>
        /// <para>The rule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RuleCategory")]
        [Validation(Required=false)]
        public string RuleCategory { get; set; }

        /// <summary>
        /// <para>The ID of the audit rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>994007</para>
        /// </summary>
        [NameInMap("RuleID")]
        [Validation(Required=false)]
        public string RuleID { get; set; }

        /// <summary>
        /// <para>The ID of the audit rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>867028</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the audit rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_rule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from test03</para>
        /// </summary>
        [NameInMap("SqlText")]
        [Validation(Required=false)]
        public string SqlText { get; set; }

        /// <summary>
        /// <para>The start time for querying alert logs, provided as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1616068534877</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
