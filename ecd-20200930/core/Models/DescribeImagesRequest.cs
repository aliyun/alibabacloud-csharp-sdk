// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImagesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        [NameInMap("ImageStatus")]
        [Validation(Required=false)]
        public string ImageStatus { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        [NameInMap("GpuCategory")]
        [Validation(Required=false)]
        public bool? GpuCategory { get; set; }

    }

}
