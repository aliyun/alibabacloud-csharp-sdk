// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class PopCreateObjectProjectRequest : TeaModel {
        [NameInMap("AutoBuild")]
        [Validation(Required=false)]
        public bool? AutoBuild { get; set; }

        [NameInMap("BizUsage")]
        [Validation(Required=false)]
        public string BizUsage { get; set; }

        [NameInMap("CustomSource")]
        [Validation(Required=false)]
        public string CustomSource { get; set; }

        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public string Dependencies { get; set; }

        [NameInMap("ForeignUid")]
        [Validation(Required=false)]
        public string ForeignUid { get; set; }

        [NameInMap("Intro")]
        [Validation(Required=false)]
        public string Intro { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("RecommendStatus")]
        [Validation(Required=false)]
        public string RecommendStatus { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
