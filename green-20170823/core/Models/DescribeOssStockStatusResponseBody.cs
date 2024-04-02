// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeOssStockStatusResponseBody : TeaModel {
        [NameInMap("AudioAntispamCount")]
        [Validation(Required=false)]
        public int? AudioAntispamCount { get; set; }

        [NameInMap("AudioTotalCount")]
        [Validation(Required=false)]
        public int? AudioTotalCount { get; set; }

        [NameInMap("BucketList")]
        [Validation(Required=false)]
        public List<DescribeOssStockStatusResponseBodyBucketList> BucketList { get; set; }
        public class DescribeOssStockStatusResponseBodyBucketList : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("Prefixes")]
            [Validation(Required=false)]
            public List<string> Prefixes { get; set; }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public bool? Selected { get; set; }

        }

        [NameInMap("FinishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        [NameInMap("ImageAdCount")]
        [Validation(Required=false)]
        public int? ImageAdCount { get; set; }

        [NameInMap("ImageLiveCount")]
        [Validation(Required=false)]
        public int? ImageLiveCount { get; set; }

        [NameInMap("ImagePornCount")]
        [Validation(Required=false)]
        public int? ImagePornCount { get; set; }

        [NameInMap("ImageTerrorismCount")]
        [Validation(Required=false)]
        public int? ImageTerrorismCount { get; set; }

        [NameInMap("ImageTotalCount")]
        [Validation(Required=false)]
        public int? ImageTotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResouceTypeList")]
        [Validation(Required=false)]
        public List<string> ResouceTypeList { get; set; }

        [NameInMap("SceneList")]
        [Validation(Required=false)]
        public List<string> SceneList { get; set; }

        [NameInMap("StockStatus")]
        [Validation(Required=false)]
        public int? StockStatus { get; set; }

        [NameInMap("VideoAdCount")]
        [Validation(Required=false)]
        public int? VideoAdCount { get; set; }

        [NameInMap("VideoLiveCount")]
        [Validation(Required=false)]
        public int? VideoLiveCount { get; set; }

        [NameInMap("VideoPornCount")]
        [Validation(Required=false)]
        public int? VideoPornCount { get; set; }

        [NameInMap("VideoTerrorismCount")]
        [Validation(Required=false)]
        public int? VideoTerrorismCount { get; set; }

        [NameInMap("VideoTotalCount")]
        [Validation(Required=false)]
        public int? VideoTotalCount { get; set; }

        [NameInMap("VideoVoiceAntispamCount")]
        [Validation(Required=false)]
        public int? VideoVoiceAntispamCount { get; set; }

    }

}
