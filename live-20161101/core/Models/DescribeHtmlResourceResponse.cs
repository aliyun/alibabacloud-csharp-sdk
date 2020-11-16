// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeHtmlResourceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("HtmlResource")]
        [Validation(Required=true)]
        public DescribeHtmlResourceResponseHtmlResource HtmlResource { get; set; }
        public class DescribeHtmlResourceResponseHtmlResource : TeaModel {
            [NameInMap("HtmlResourceId")]
            [Validation(Required=true)]
            public string HtmlResourceId { get; set; }
            [NameInMap("HtmlUrl")]
            [Validation(Required=true)]
            public string HtmlUrl { get; set; }
            [NameInMap("HtmlContent")]
            [Validation(Required=true)]
            public string HtmlContent { get; set; }
            [NameInMap("CasterId")]
            [Validation(Required=true)]
            public string CasterId { get; set; }
            [NameInMap("Config")]
            [Validation(Required=true)]
            public string Config { get; set; }
            [NameInMap("StreamId")]
            [Validation(Required=true)]
            public string StreamId { get; set; }
        };

    }

}
