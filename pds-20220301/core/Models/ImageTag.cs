// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImageTag : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("cover_file_category")]
        [Validation(Required=false)]
        public string CoverFileCategory { get; set; }

        [NameInMap("cover_file_id")]
        [Validation(Required=false)]
        public string CoverFileId { get; set; }

        [NameInMap("cover_overall_score")]
        [Validation(Required=false)]
        public float? CoverOverallScore { get; set; }

        [NameInMap("cover_tag_confidence")]
        [Validation(Required=false)]
        public float? CoverTagConfidence { get; set; }

        [NameInMap("cover_url")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
