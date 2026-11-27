// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class PushDeviceRenderMessageRequest : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public PushDeviceRenderMessageRequestDeviceInfo DeviceInfo { get; set; }
        public class PushDeviceRenderMessageRequestDeviceInfo : TeaModel {
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
        public PushDeviceRenderMessageRequestPayload Payload { get; set; }
        public class PushDeviceRenderMessageRequestPayload : TeaModel {
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public int? MsgId { get; set; }

            [NameInMap("Tts")]
            [Validation(Required=false)]
            public string Tts { get; set; }

            [NameInMap("UiContent")]
            [Validation(Required=false)]
            public string UiContent { get; set; }

        }

    }

}
