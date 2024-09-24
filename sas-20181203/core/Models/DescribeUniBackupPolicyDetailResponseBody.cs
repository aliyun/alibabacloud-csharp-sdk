// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupPolicyDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D0760****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the anti-ransomware policy.</para>
        /// </summary>
        [NameInMap("UniBackupPolicyDTO")]
        [Validation(Required=false)]
        public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTO UniBackupPolicyDTO { get; set; }
        public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTO : TeaModel {
            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The status of the database client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UNKNOWN</b>: unknown</description></item>
            /// <item><description><b>INSTALLED</b>: installed</description></item>
            /// <item><description><b>INSTALL_FAILED</b>: installation failed</description></item>
            /// <item><description><b>UNINSTALL_FAILED</b>: uninstallation failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTALLED</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// <para>The type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MYSQL</b></description></item>
            /// <item><description><b>MSSQL</b></description></item>
            /// <item><description><b>Oracle</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ORACLE</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <para>The details of the policy for full backup.</para>
            /// </summary>
            [NameInMap("FullPlan")]
            [Validation(Required=false)]
            public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOFullPlan FullPlan { get; set; }
            public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOFullPlan : TeaModel {
                /// <summary>
                /// <para>An array that consists of the days of a week on which the backup is performed.</para>
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<string> Days { get; set; }

                /// <summary>
                /// <para>The interval of backup tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The unit of the interval. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>hourly</b>: hour</description></item>
                /// <item><description><b>daily</b>: day</description></item>
                /// <item><description><b>weekly</b>: week</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>daily</para>
                /// </summary>
                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                /// <summary>
                /// <para>The time when the full backup started. The time is in the HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:10:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The policy for incremental data backup.</para>
            /// </summary>
            [NameInMap("IncPlan")]
            [Validation(Required=false)]
            public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOIncPlan IncPlan { get; set; }
            public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOIncPlan : TeaModel {
                /// <summary>
                /// <para>An array that consists of the days of a week on which the backup is performed.</para>
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<string> Days { get; set; }

                /// <summary>
                /// <para>The interval of backup tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The unit of the interval. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>hourly</b>: hour</description></item>
                /// <item><description><b>daily</b>: day</description></item>
                /// <item><description><b>weekly</b>: week</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>daily</para>
                /// </summary>
                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                /// <summary>
                /// <para>The time when the incremental data backup starts. The time is in the hh:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:10:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zefcy2id5d60m9t****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-01</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

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
            /// <para>auto_test_sql</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>initiating</b>: initializing</description></item>
            /// <item><description><b>opening</b>: enabled</description></item>
            /// <item><description><b>closing</b>: disabled</description></item>
            /// <item><description><b>deleting</b>: deleting</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>opening</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>The retention period of the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            /// <summary>
            /// <para>The maximum network bandwidth that is allowed during data backup. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5242880</para>
            /// </summary>
            [NameInMap("SpeedLimiter")]
            [Validation(Required=false)]
            public long? SpeedLimiter { get; set; }

        }

    }

}
