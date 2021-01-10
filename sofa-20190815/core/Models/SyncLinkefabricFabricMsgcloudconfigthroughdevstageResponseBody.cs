// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SyncLinkefabricFabricMsgcloudconfigthroughdevstageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SyncLinkefabricFabricMsgcloudconfigthroughdevstageResponseBodyData> Data { get; set; }
        public class SyncLinkefabricFabricMsgcloudconfigthroughdevstageResponseBodyData : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DevStage")]
            [Validation(Required=false)]
            public string DevStage { get; set; }

            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("TagType")]
            [Validation(Required=false)]
            public string TagType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

        }

    }

}
