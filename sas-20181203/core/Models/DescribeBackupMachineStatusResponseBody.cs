// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupMachineStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup status of the server.</para>
        /// </summary>
        [NameInMap("BackupMachineStatus")]
        [Validation(Required=false)]
        public DescribeBackupMachineStatusResponseBodyBackupMachineStatus BackupMachineStatus { get; set; }
        public class DescribeBackupMachineStatusResponseBodyBackupMachineStatus : TeaModel {
            /// <summary>
            /// <para>The ID of the anti-ransomware client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-000dbefaw9f7gnbw****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The service status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ONLINE</b>: Normal.</description></item>
            /// <item><description><b>CLIENT_CONNECTION_ERROR</b>: Client connection exception.</description></item>
            /// <item><description><b>UNINSTALLING</b>: Uninstalling.</description></item>
            /// <item><description><b>UNINSTALL_FAILED</b>: Uninstall failed.</description></item>
            /// <item><description><b>UPGRADING</b>: Upgrading.</description></item>
            /// <item><description><b>UPGRADE_FAILED</b>: Upgrade failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The version number of the anti-ransomware client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.11.0</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The error code returned for an abnormal status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLIENT_CONNECTION_ERROR</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The list of error messages reported by the backup server.</para>
            /// </summary>
            [NameInMap("ErrorList")]
            [Validation(Required=false)]
            public List<DescribeBackupMachineStatusResponseBodyBackupMachineStatusErrorList> ErrorList { get; set; }
            public class DescribeBackupMachineStatusResponseBodyBackupMachineStatusErrorList : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TARGET_NOT_EXIST</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error status information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FAILED</para>
                /// </summary>
                [NameInMap("ErrorStatus")]
                [Validation(Required=false)]
                public string ErrorStatus { get; set; }

            }

            /// <summary>
            /// <para>The ID of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zeaqkb80vloxjcj****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of restorable versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("SavedBackupCount")]
            [Validation(Required=false)]
            public int? SavedBackupCount { get; set; }

            /// <summary>
            /// <para>The service status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SERVICE_EXCEPTION</b>: Service exception.</description></item>
            /// <item><description><b>RESTORING</b>: Restoring.</description></item>
            /// <item><description><b>BACKING_UP</b>: Backing up.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RESTORING</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NOT_INSTALLED</b>: not installed</description></item>
            /// <item><description><b>CLIENT_CONNECTION_ERROR</b>: client status exception</description></item>
            /// <item><description><b>ACTIVATED</b>: normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb2c782e-64f2-4590-a86c-d90164df****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the backup vault where the backup data is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v-0005i2qh5fcr6seo****</para>
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
