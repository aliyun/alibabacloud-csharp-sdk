// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The following parameters are no longer used. Ignore the parameters.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeBackupPolicyResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The retention period of the backup data. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>Indicates whether the backup-as-a-service feature is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The backup-as-a-service feature is enabled for the instance.</description></item>
        /// <item><description><b>0</b>: The backup-as-a-service feature is disabled for the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DbsInstance")]
        [Validation(Required=false)]
        public string DbsInstance { get; set; }

        /// <summary>
        /// <para>Indicates whether incremental data backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Incremental data backup is enabled.</description></item>
        /// <item><description><b>0</b>: Incremental data backup is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time range during which the backup was created. The time follows the ISO 8601 standard in the <em>HH:mm</em>Z-<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05:00Z-06:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The next backup time. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-14T05:28Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90B82DB7-FB28-4CC2-ADBF-1F8659F3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
