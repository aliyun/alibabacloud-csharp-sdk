// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class AppUseTimeReportRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public AppUseTimeReportRequestDeviceInfo DeviceInfo { get; set; }
        public class AppUseTimeReportRequestDeviceInfo : TeaModel {
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
        public AppUseTimeReportRequestPayload Payload { get; set; }
        public class AppUseTimeReportRequestPayload : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("IsPrivilege")]
            [Validation(Required=false)]
            public int? IsPrivilege { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public int? ResourceType { get; set; }

            [NameInMap("StepCode")]
            [Validation(Required=false)]
            public string StepCode { get; set; }

            [NameInMap("VipType")]
            [Validation(Required=false)]
            public int? VipType { get; set; }

            [NameInMap("originUuid")]
            [Validation(Required=false)]
            public string OriginUuid { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public AppUseTimeReportRequestUserInfo UserInfo { get; set; }
        public class AppUseTimeReportRequestUserInfo : TeaModel {
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
