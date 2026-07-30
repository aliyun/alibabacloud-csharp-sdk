// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAuditLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3926fba5-1774-44f4-af2d-ac7b33e86c3b</para>
        /// </summary>
        [NameInMap("AsyncRequestId")]
        [Validation(Required=false)]
        public string AsyncRequestId { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The client IP addresses in the SQL log records.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAuditLogsResponseBodyItems> Items { get; set; }
        public class DescribeAuditLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The client IP address in the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.16.251</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The client port number in the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53815</para>
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public string ClientPort { get; set; }

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
            /// <para>The column name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The alert time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chngc_b2b_migration_sh</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

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
            /// <para>The execution status. Valid values: 0: failed. 1: succeeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecuteStatus")]
            [Validation(Required=false)]
            public int? ExecuteStatus { get; set; }

            /// <summary>
            /// <para>The execution duration, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751870592000</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public long? ExecuteTime { get; set; }

            /// <summary>
            /// <para>The primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert is in the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("InWhiteList")]
            [Validation(Required=false)]
            public bool? InWhiteList { get; set; }

            /// <summary>
            /// <para>The instance audit status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InstanceAuditStatus")]
            [Validation(Required=false)]
            public string InstanceAuditStatus { get; set; }

            /// <summary>
            /// <para>The description of the data asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance dscription</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The instance alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-instance-003</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <para><b>default</b> (default): non-Alibaba Cloud service.</para>
            /// <para><b>aliyun</b>: Alibaba Cloud service.</para>
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
            /// <para>The log execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751870592000</para>
            /// </summary>
            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public long? LogTime { get; set; }

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
            /// <para>The operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Drop</para>
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// <para>The key of the OSS storage object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N.A</para>
            /// </summary>
            [NameInMap("OssObjectKey")]
            [Validation(Required=false)]
            public string OssObjectKey { get; set; }

            /// <summary>
            /// <para>The MaxCompute package name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <para>The name of the product to which the data asset belongs. Valid values: RDS, PolarDB, PolarDB-X 2.0, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID that corresponds to the product name to which the data object belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>3: ADB-MYSQL</description></item>
            /// <item><description>5: RDS</description></item>
            /// <item><description>7: PolarDB-X</description></item>
            /// <item><description>8: PolarDB</description></item>
            /// <item><description>9: ADB-PG</description></item>
            /// <item><description>11: MongoDB</description></item>
            /// <item><description>25: Redis</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

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
            /// <para>The ID of the audit policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9953411</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the audit policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
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
            /// <para>The table name used in the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>it_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The user UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19********94</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
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
            /// <item><description><b>1</b>: low-risk.</description></item>
            /// <item><description><b>2</b>: medium-risk.</description></item>
            /// <item><description><b>3</b>: high-risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WarnLevel")]
            [Validation(Required=false)]
            public string WarnLevel { get; set; }

            /// <summary>
            /// <para>The name of the risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Low-risk.</description></item>
            /// <item><description>Medium-risk.</description></item>
            /// <item><description>High-risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WarnLevelName")]
            [Validation(Required=false)]
            public string WarnLevelName { get; set; }

        }

        /// <summary>
        /// <para>The page size for the paged query. This parameter indicates the number of entries per page for paging.</para>
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
        /// <para>The total number of records. This parameter is valid only for the Redis engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
