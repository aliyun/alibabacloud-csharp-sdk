// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateParamsResponseBody : TeaModel {
        [NameInMap("ParamList")]
        [Validation(Required=false)]
        public List<GetTemplateParamsResponseBodyParamList> ParamList { get; set; }
        public class GetTemplateParamsResponseBodyParamList : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("MediaUrl")]
            [Validation(Required=false)]
            public string MediaUrl { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
