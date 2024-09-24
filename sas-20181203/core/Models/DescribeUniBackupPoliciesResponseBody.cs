// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeUniBackupPoliciesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeUniBackupPoliciesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACF97412-FD09-4D1F-994F-34DF12BR****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the anti-ransomware policies.</para>
        /// </summary>
        [NameInMap("UniBackupPolicies")]
        [Validation(Required=false)]
        public List<DescribeUniBackupPoliciesResponseBodyUniBackupPolicies> UniBackupPolicies { get; set; }
        public class DescribeUniBackupPoliciesResponseBodyUniBackupPolicies : TeaModel {
            /// <summary>
            /// <para>The error message for the anti-ransomware agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTALL_TIMEOUT</para>
            /// </summary>
            [NameInMap("AgentErrorMessage")]
            [Validation(Required=false)]
            public string AgentErrorMessage { get; set; }

            /// <summary>
            /// <para>The status of the agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UNKNOWN</b></description></item>
            /// <item><description><b>INSTALLED</b></description></item>
            /// <item><description><b>INSTALL_FAILED</b></description></item>
            /// <item><description><b>UNINSTALL_FAILED</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTALLED</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MYSQL</b></description></item>
            /// <item><description><b>MSSQL</b></description></item>
            /// <item><description><b>Oracle</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MYSQL</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <para>The error code returned when the backup task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXPIRED</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message for the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AttachRamRoleError</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-9dp7mubt5wit6g0h****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-001</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The status of the Elastic Compute Service (ECS) instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Stopped</b></description></item>
            /// <item><description><b>Running</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The UUID of the agent that is used to back up the data of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cf1bcad4063f11ed800000163e0e****</para>
            /// </summary>
            [NameInMap("InstanceUuid")]
            [Validation(Required=false)]
            public string InstanceUuid { get; set; }

            /// <summary>
            /// <para>The execution result of the last backup task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("LatestBackResult")]
            [Validation(Required=false)]
            public string LatestBackResult { get; set; }

            /// <summary>
            /// <para>The time when the last backup task was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01 00:00:11</para>
            /// </summary>
            [NameInMap("LatestBackupTime")]
            [Validation(Required=false)]
            public string LatestBackupTime { get; set; }

            /// <summary>
            /// <para>The status of the backup task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init</b></description></item>
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>completed</b></description></item>
            /// <item><description><b>restoring</b></description></item>
            /// <item><description><b>creating</b></description></item>
            /// <item><description><b>created</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>creating</para>
            /// </summary>
            [NameInMap("PlanStatus")]
            [Validation(Required=false)]
            public string PlanStatus { get; set; }

            /// <summary>
            /// <para>The ID of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_oracle_37f</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>initiating</b></description></item>
            /// <item><description><b>opening</b></description></item>
            /// <item><description><b>closing</b></description></item>
            /// <item><description><b>deleting</b></description></item>
            /// <item><description><b>enabled</b></description></item>
            /// <item><description><b>disabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>opening</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>The region ID of the server that hosts the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("UniRegionId")]
            [Validation(Required=false)]
            public string UniRegionId { get; set; }

        }

    }

}
