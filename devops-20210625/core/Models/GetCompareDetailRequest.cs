// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetCompareDetailRequest : TeaModel {
        [NameInMap("from")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("maxDiffByte")]
        [Validation(Required=false)]
        public int? MaxDiffByte { get; set; }

        [NameInMap("maxDiffFile")]
        [Validation(Required=false)]
        public int? MaxDiffFile { get; set; }

        [NameInMap("mergeBase")]
        [Validation(Required=false)]
        public bool? MergeBase { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("to")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}
