// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewayHaResponseBody : TeaModel {
        [NameInMap("BackupDeviceId")]
        [Validation(Required=false)]
        public string BackupDeviceId { get; set; }

        [NameInMap("DeviceLevelBackupState")]
        [Validation(Required=false)]
        public string DeviceLevelBackupState { get; set; }

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

        [NameInMap("MainDeviceId")]
        [Validation(Required=false)]
        public string MainDeviceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

    }

}
