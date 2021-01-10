// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeHtmlResourceRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("HtmlResourceId")]
        [Validation(Required=false)]
        public string HtmlResourceId { get; set; }

        [NameInMap("htmlUrl")]
        [Validation(Required=false)]
        public string HtmlUrl { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

    }

}
