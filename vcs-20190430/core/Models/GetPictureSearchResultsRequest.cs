// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20190430.Models
{
    public class GetPictureSearchResultsRequest : TeaModel {
        [NameInMap("AlgorithmType")]
        [Validation(Required=false)]
        public string AlgorithmType { get; set; }

        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public string DeviceList { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PictureContents")]
        [Validation(Required=false)]
        public string PictureContents { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TopNum")]
        [Validation(Required=false)]
        public int? TopNum { get; set; }

        [NameInMap("VcsId")]
        [Validation(Required=false)]
        public string VcsId { get; set; }

    }

}
