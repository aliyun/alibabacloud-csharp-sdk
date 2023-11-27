// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ImportMessageRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public ImportMessageRequestRequestParams RequestParams { get; set; }
        public class ImportMessageRequestRequestParams : TeaModel {
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ImportMessageRequestRequestParamsMessages> Messages { get; set; }
            public class ImportMessageRequestRequestParamsMessages : TeaModel {
                [NameInMap("AppCid")]
                [Validation(Required=false)]
                public string AppCid { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public long? ContentType { get; set; }

                [NameInMap("ConversationType")]
                [Validation(Required=false)]
                public long? ConversationType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extensions { get; set; }

                [NameInMap("ReceiverIds")]
                [Validation(Required=false)]
                public List<string> ReceiverIds { get; set; }

                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

    }

}
