// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetIdpConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIdpConfigResponseBodyData Data { get; set; }
        public class GetIdpConfigResponseBodyData : TeaModel {
            /// <summary>
            /// AccessKey ID
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// AccessKey Secret
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GetGroupUrl")]
            [Validation(Required=false)]
            public string GetGroupUrl { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdpMetadata")]
            [Validation(Required=false)]
            public string IdpMetadata { get; set; }

            [NameInMap("MfaConfigType")]
            [Validation(Required=false)]
            public string MfaConfigType { get; set; }

            [NameInMap("MobileLoginType")]
            [Validation(Required=false)]
            public string MobileLoginType { get; set; }

            [NameInMap("MobileMfaConfigType")]
            [Validation(Required=false)]
            public string MobileMfaConfigType { get; set; }

            [NameInMap("MultiIdpInfo")]
            [Validation(Required=false)]
            public string MultiIdpInfo { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PcLoginType")]
            [Validation(Required=false)]
            public string PcLoginType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("VerifyAesKey")]
            [Validation(Required=false)]
            public string VerifyAesKey { get; set; }

            [NameInMap("VerifyToken")]
            [Validation(Required=false)]
            public string VerifyToken { get; set; }

            [NameInMap("VerifyUrl")]
            [Validation(Required=false)]
            public string VerifyUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
