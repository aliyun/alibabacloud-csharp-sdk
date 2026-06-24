// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeAuditLogsResponseBody : TeaModel {
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
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>An array of alert logs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAuditLogsResponseBodyItems> Items { get; set; }
        public class DescribeAuditLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The client IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139.<em>.</em>.57</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The client port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35756</para>
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public string ClientPort { get; set; }

            /// <summary>
            /// <para>The user agent of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("ClientUa")]
            [Validation(Required=false)]
            public string ClientUa { get; set; }

            /// <summary>
            /// <para>The name of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hide14</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The time when the alert was generated. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The SQL result set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan_id ~ application_id ~ plan_type ~ plan_name ~ plan_value_id</para>
            /// </summary>
            [NameInMap("DataSet")]
            [Validation(Required=false)]
            public string DataSet { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chngc_b2b_migration_sh</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The type of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The number of affected rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EffectRow")]
            [Validation(Required=false)]
            public long? EffectRow { get; set; }

            /// <summary>
            /// <para>The execution status. Valid values: 0 (failed) and 1 (successful).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecuteStatus")]
            [Validation(Required=false)]
            public int? ExecuteStatus { get; set; }

            /// <summary>
            /// <para>The execution duration in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751870592000</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public long? ExecuteTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation is whitelisted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InWhiteList")]
            [Validation(Required=false)]
            public bool? InWhiteList { get; set; }

            /// <summary>
            /// <para>The audit status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InstanceAuditStatus")]
            [Validation(Required=false)]
            public string InstanceAuditStatus { get; set; }

            /// <summary>
            /// <para>The description of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance dscription</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The name of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-1234</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <para><b>default</b>: a non-Alibaba Cloud service. This is the default value.</para>
            /// <para><b>aliyun</b>: an Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

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
            /// <para>The time when the operation was logged. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751870592000</para>
            /// </summary>
            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public long? LogTime { get; set; }

            /// <summary>
            /// <para>The ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public string MemberAccount { get; set; }

            /// <summary>
            /// <para>The raw log content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The sensitive data detection rule that was matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Identity Card</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Drop</para>
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// <para>The key of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-key1</para>
            /// </summary>
            [NameInMap("OssObjectKey")]
            [Validation(Required=false)]
            public string OssObjectKey { get; set; }

            /// <summary>
            /// <para>The name of the MaxCompute package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <para>The code of the Alibaba Cloud service. Examples: <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud service that contains the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: ADS</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: OTS</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: RDS</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: SELF_DB</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            [NameInMap("RamConsoleLink")]
            [Validation(Required=false)]
            public string RamConsoleLink { get; set; }

            /// <summary>
            /// <para>The type of the rule.</para>
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
            /// <para>9952275</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the audit rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The SQL statement in the alert log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * from test03</para>
            /// </summary>
            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public string SqlText { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>it_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19********94</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Low</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Medium</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: High</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WarnLevel")]
            [Validation(Required=false)]
            public string WarnLevel { get; set; }

            /// <summary>
            /// <para>The name of the risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Low</para>
            /// </description></item>
            /// <item><description><para>Medium</para>
            /// </description></item>
            /// <item><description><para>High</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>High risk</para>
            /// </summary>
            [NameInMap("WarnLevelName")]
            [Validation(Required=false)]
            public string WarnLevelName { get; set; }

        }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7021857-AFD9-5AD6-979D-AA7DFC5AFADF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
