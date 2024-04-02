// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UpdateOssStockStatusRequest : TeaModel {
        [NameInMap("AudioAutoFreezeSceneList")]
        [Validation(Required=false)]
        public string AudioAutoFreezeSceneList { get; set; }

        [NameInMap("AudioMaxSize")]
        [Validation(Required=false)]
        public int? AudioMaxSize { get; set; }

        [NameInMap("AutoFreezeType")]
        [Validation(Required=false)]
        public string AutoFreezeType { get; set; }

        [NameInMap("BucketConfigList")]
        [Validation(Required=false)]
        public string BucketConfigList { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("ImageAutoFreeze")]
        [Validation(Required=false)]
        public string ImageAutoFreeze { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        [NameInMap("ResourceTypeList")]
        [Validation(Required=false)]
        public string ResourceTypeList { get; set; }

        [NameInMap("SceneList")]
        [Validation(Required=false)]
        public string SceneList { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("VideoAutoFreezeSceneList")]
        [Validation(Required=false)]
        public string VideoAutoFreezeSceneList { get; set; }

        [NameInMap("VideoFrameInterval")]
        [Validation(Required=false)]
        public int? VideoFrameInterval { get; set; }

        [NameInMap("VideoMaxFrames")]
        [Validation(Required=false)]
        public int? VideoMaxFrames { get; set; }

        [NameInMap("VideoMaxSize")]
        [Validation(Required=false)]
        public int? VideoMaxSize { get; set; }

    }

}
