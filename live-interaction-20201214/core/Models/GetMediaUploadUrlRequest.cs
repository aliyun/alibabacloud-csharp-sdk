// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetMediaUploadUrlRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public GetMediaUploadUrlRequestRequestParams RequestParams { get; set; }
        public class GetMediaUploadUrlRequestRequestParams : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
        };

    }

}
