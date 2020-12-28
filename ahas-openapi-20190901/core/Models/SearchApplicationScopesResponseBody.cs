// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class SearchApplicationScopesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<SearchApplicationScopesResponseBodyContent> Content { get; set; }
        public class SearchApplicationScopesResponseBodyContent : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("ConfigurationId")]
            [Validation(Required=false)]
            public string ConfigurationId { get; set; }

            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public int? DeviceType { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            [NameInMap("HostConfigurationId")]
            [Validation(Required=false)]
            public string HostConfigurationId { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
