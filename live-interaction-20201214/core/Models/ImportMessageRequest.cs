// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ImportMessageRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
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
                public string Uuid { get; set; }
                public string AppCid { get; set; }
                public long? ConversationType { get; set; }
                public string SenderId { get; set; }
                public List<string> ReceiverIds { get; set; }
                public long? ContentType { get; set; }
                public string Content { get; set; }
                public long? CreateTime { get; set; }
                public Dictionary<string, string> Extensions { get; set; }
            }
        };

    }

}
