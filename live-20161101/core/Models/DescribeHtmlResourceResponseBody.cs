// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeHtmlResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HtmlResource")]
        [Validation(Required=false)]
        public DescribeHtmlResourceResponseBodyHtmlResource HtmlResource { get; set; }
        public class DescribeHtmlResourceResponseBodyHtmlResource : TeaModel {
            [NameInMap("HtmlResourceId")]
            [Validation(Required=false)]
            public string HtmlResourceId { get; set; }
            [NameInMap("HtmlUrl")]
            [Validation(Required=false)]
            public string HtmlUrl { get; set; }
            [NameInMap("HtmlContent")]
            [Validation(Required=false)]
            public string HtmlContent { get; set; }
            [NameInMap("CasterId")]
            [Validation(Required=false)]
            public string CasterId { get; set; }
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }
            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }
        };

    }

}
