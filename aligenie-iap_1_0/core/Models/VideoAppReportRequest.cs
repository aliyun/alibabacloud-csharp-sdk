// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class VideoAppReportRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public VideoAppReportRequestDeviceInfo DeviceInfo { get; set; }
        public class VideoAppReportRequestDeviceInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public VideoAppReportRequestPayload Payload { get; set; }
        public class VideoAppReportRequestPayload : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("isLogin")]
            [Validation(Required=false)]
            public bool? IsLogin { get; set; }

            [NameInMap("isVip")]
            [Validation(Required=false)]
            public bool? IsVip { get; set; }

            [NameInMap("loginNick")]
            [Validation(Required=false)]
            public string LoginNick { get; set; }

            [NameInMap("originUuid")]
            [Validation(Required=false)]
            public string OriginUuid { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("pkgName")]
            [Validation(Required=false)]
            public string PkgName { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public VideoAppReportRequestUserInfo UserInfo { get; set; }
        public class VideoAppReportRequestUserInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
