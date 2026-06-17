// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLogBackupPolicyResponseBody : TeaModel {
        [NameInMap("AdvancedLogPolicies")]
        [Validation(Required=false)]
        public DescribeLogBackupPolicyResponseBodyAdvancedLogPolicies AdvancedLogPolicies { get; set; }
        public class DescribeLogBackupPolicyResponseBodyAdvancedLogPolicies : TeaModel {
            [NameInMap("AdvancedLogPolicy")]
            [Validation(Required=false)]
            public List<DescribeLogBackupPolicyResponseBodyAdvancedLogPoliciesAdvancedLogPolicy> AdvancedLogPolicy { get; set; }
            public class DescribeLogBackupPolicyResponseBodyAdvancedLogPoliciesAdvancedLogPolicy : TeaModel {
                [NameInMap("DestRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

                [NameInMap("EnableLogBackup")]
                [Validation(Required=false)]
                public int? EnableLogBackup { get; set; }

                [NameInMap("LogRetentionType")]
                [Validation(Required=false)]
                public string LogRetentionType { get; set; }

                [NameInMap("LogRetentionValue")]
                [Validation(Required=false)]
                public string LogRetentionValue { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                [NameInMap("SrcRegion")]
                [Validation(Required=false)]
                public string SrcRegion { get; set; }

                [NameInMap("SrcType")]
                [Validation(Required=false)]
                public string SrcType { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the log backup feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The feature is disabled.</para>
        /// </description></item>
        /// <item><description><para>1: The feature is enabled. By default, the log backup feature is enabled and cannot be disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the advanced backup feature is enabled, this parameter is not recommended. Use the AdvancedLogPolicies parameter instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The region in which the cross-region log backup is stored. For information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// <remarks>
        /// <para>If the advanced backup feature is enabled, this parameter is not recommended. Use the AdvancedLogPolicies parameter instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("LogBackupAnotherRegionRegion")]
        [Validation(Required=false)]
        public string LogBackupAnotherRegionRegion { get; set; }

        /// <summary>
        /// <para>The retention period of the cross-region log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: The cross-region log backup feature is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>30 to 7300</b>: The cross-region log backup is retained for 30 to 7300 days.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: The cross-region log backups are retained permanently.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When you create a cluster, the default value is <b>0</b>. This value indicates that the cross-region log backup feature is disabled.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the advanced backup feature is enabled, this parameter is not recommended. Use the AdvancedLogPolicies parameter instead.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LogBackupAnotherRegionRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupAnotherRegionRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The retention period of the log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>3 to 7300: The log backup is retained for 3 to 7300 days.</para>
        /// </description></item>
        /// <item><description><para>-1: The log backups are retained permanently.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the advanced backup feature is enabled, this parameter is not recommended. Use the AdvancedLogPolicies parameter instead.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62EE0051-102B-488D-9C79-D607B8******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
