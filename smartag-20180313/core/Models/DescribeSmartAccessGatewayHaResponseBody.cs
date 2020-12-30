// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewayHaResponseBody : TeaModel {
        [NameInMap("DeviceLevelBackupState")]
        [Validation(Required=false)]
        public string DeviceLevelBackupState { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackupDeviceId")]
        [Validation(Required=false)]
        public string BackupDeviceId { get; set; }

        [NameInMap("LinkBackupInfoList")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayHaResponseBodyLinkBackupInfoList LinkBackupInfoList { get; set; }
        public class DescribeSmartAccessGatewayHaResponseBodyLinkBackupInfoList : TeaModel {
            [NameInMap("LinkBackupInfoList")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayHaResponseBodyLinkBackupInfoListLinkBackupInfoList> LinkBackupInfoList { get; set; }
            public class DescribeSmartAccessGatewayHaResponseBodyLinkBackupInfoListLinkBackupInfoList : TeaModel {
                public string MainLinkId { get; set; }
                public string BackupLinkState { get; set; }
                public string LinkLevelBackupState { get; set; }
                public string BackupLinkId { get; set; }
                public string MainLinkState { get; set; }
                public string LinkLevelBackupType { get; set; }
            }
        };

        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        [NameInMap("DeviceLevelBackupType")]
        [Validation(Required=false)]
        public string DeviceLevelBackupType { get; set; }

        [NameInMap("MainDeviceId")]
        [Validation(Required=false)]
        public string MainDeviceId { get; set; }

    }

}
