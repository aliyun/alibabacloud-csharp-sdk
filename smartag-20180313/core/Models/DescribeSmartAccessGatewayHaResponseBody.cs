// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewayHaResponseBody : TeaModel {
        /// <summary>
        /// <para>The serial number of the standby SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag11axxxx</para>
        /// </summary>
        [NameInMap("BackupDeviceId")]
        [Validation(Required=false)]
        public string BackupDeviceId { get; set; }

        /// <summary>
        /// <para>Indicates whether device-based HA is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: enabled</description></item>
        /// <item><description><b>OFF</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("DeviceLevelBackupState")]
        [Validation(Required=false)]
        public string DeviceLevelBackupState { get; set; }

        /// <summary>
        /// <para>The deployment mode of the SAG devices that have HA enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>warm_backup</b>: active-active mode.</description></item>
        /// <item><description><b>cold_backup</b>: active-standby mode.</description></item>
        /// <item><description><b>no_backup</b>: HA is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cold_backup</para>
        /// </summary>
        [NameInMap("DeviceLevelBackupType")]
        [Validation(Required=false)]
        public string DeviceLevelBackupType { get; set; }

        [NameInMap("LinkBackupInfoList")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayHaResponseBodyLinkBackupInfoList LinkBackupInfoList { get; set; }
        public class DescribeSmartAccessGatewayHaResponseBodyLinkBackupInfoList : TeaModel {
            [NameInMap("LinkBackupInfoList")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayHaResponseBodyLinkBackupInfoListLinkBackupInfoList> LinkBackupInfoList { get; set; }
            public class DescribeSmartAccessGatewayHaResponseBodyLinkBackupInfoListLinkBackupInfoList : TeaModel {
                [NameInMap("BackupLinkId")]
                [Validation(Required=false)]
                public string BackupLinkId { get; set; }

                [NameInMap("BackupLinkState")]
                [Validation(Required=false)]
                public string BackupLinkState { get; set; }

                [NameInMap("LinkLevelBackupState")]
                [Validation(Required=false)]
                public string LinkLevelBackupState { get; set; }

                [NameInMap("LinkLevelBackupType")]
                [Validation(Required=false)]
                public string LinkLevelBackupType { get; set; }

                [NameInMap("MainLinkId")]
                [Validation(Required=false)]
                public string MainLinkId { get; set; }

                [NameInMap("MainLinkState")]
                [Validation(Required=false)]
                public string MainLinkState { get; set; }

            }

        }

        /// <summary>
        /// <para>The serial number of the active SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag11axxxx</para>
        /// </summary>
        [NameInMap("MainDeviceId")]
        [Validation(Required=false)]
        public string MainDeviceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>582FE511-FEFE-42BC-BBF4-4F8ECF92Exxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-i8mogwi9kisigc3xxxx</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

    }

}
