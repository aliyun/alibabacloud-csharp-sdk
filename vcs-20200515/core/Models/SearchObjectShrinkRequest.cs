// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SearchObjectShrinkRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=true)]
        public string CorpId { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=true)]
        public string ObjectType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public long StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public long EndTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public string DeviceListShrink { get; set; }

        [NameInMap("PicUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string ConditionsShrink { get; set; }

        [NameInMap("AlgorithmType")]
        [Validation(Required=false)]
        public string AlgorithmType { get; set; }

        [NameInMap("ImagePath")]
        [Validation(Required=false)]
        public string ImagePathShrink { get; set; }

    }

}
