// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLogBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the log backup feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The log backup feature is disabled.</description></item>
        /// <item><description>1: The log backup feature is enabled. By default, the log backup feature is enabled and cannot be disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The region in which you want to store cross-region log backups. For more information about regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("LogBackupAnotherRegionRegion")]
        [Validation(Required=false)]
        public string LogBackupAnotherRegionRegion { get; set; }

        /// <summary>
        /// <para>The retention period of cross-region log backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The cross-region backup feature is disabled.</description></item>
        /// <item><description><b>30 to 7300</b>: Cross-region log backups are retained for 30 to 7,300 days.</description></item>
        /// <item><description><b>-1</b>: The log backups are permanently retained.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When you create a cluster, the default value of this parameter is <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LogBackupAnotherRegionRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupAnotherRegionRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The retention period of the log backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>3 to 7300: The log backups are retained for 3 to 7,300 days.</description></item>
        /// <item><description>\-1: The log backups are permanently retained.</description></item>
        /// </list>
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
