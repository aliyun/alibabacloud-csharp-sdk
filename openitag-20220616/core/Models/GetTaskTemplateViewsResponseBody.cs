// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class GetTaskTemplateViewsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Details")]
        [Validation(Required=false)]
        public string Details { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Views")]
        [Validation(Required=false)]
        public GetTaskTemplateViewsResponseBodyViews Views { get; set; }
        public class GetTaskTemplateViewsResponseBodyViews : TeaModel {
            [NameInMap("ViewPlugins")]
            [Validation(Required=false)]
            public List<ViewPlugin> ViewPlugins { get; set; }

        }

    }

}
