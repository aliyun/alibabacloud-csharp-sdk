// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UpdateOssIncrementCheckSettingRequest : TeaModel {
        [NameInMap("AudioAntispamFreezeConfig")]
        [Validation(Required=false)]
        public string AudioAntispamFreezeConfig { get; set; }

        [NameInMap("AudioAutoFreezeOpened")]
        [Validation(Required=false)]
        public bool? AudioAutoFreezeOpened { get; set; }

        [NameInMap("AudioMaxSize")]
        [Validation(Required=false)]
        public int? AudioMaxSize { get; set; }

        [NameInMap("AudioScanLimit")]
        [Validation(Required=false)]
        public long? AudioScanLimit { get; set; }

        [NameInMap("AudioSceneList")]
        [Validation(Required=false)]
        public string AudioSceneList { get; set; }

        [NameInMap("AutoFreezeType")]
        [Validation(Required=false)]
        public string AutoFreezeType { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BucketConfigList")]
        [Validation(Required=false)]
        public string BucketConfigList { get; set; }

        [NameInMap("CallbackId")]
        [Validation(Required=false)]
        public string CallbackId { get; set; }

        [NameInMap("ImageAdFreezeConfig")]
        [Validation(Required=false)]
        public string ImageAdFreezeConfig { get; set; }

        [NameInMap("ImageAutoFreeze")]
        [Validation(Required=false)]
        public string ImageAutoFreeze { get; set; }

        [NameInMap("ImageAutoFreezeOpened")]
        [Validation(Required=false)]
        public bool? ImageAutoFreezeOpened { get; set; }

        [NameInMap("ImageLiveFreezeConfig")]
        [Validation(Required=false)]
        public string ImageLiveFreezeConfig { get; set; }

        [NameInMap("ImagePornFreezeConfig")]
        [Validation(Required=false)]
        public string ImagePornFreezeConfig { get; set; }

        [NameInMap("ImageScanLimit")]
        [Validation(Required=false)]
        public string ImageScanLimit { get; set; }

        [NameInMap("ImageSceneList")]
        [Validation(Required=false)]
        public string ImageSceneList { get; set; }

        [NameInMap("ImageTerrorismFreezeConfig")]
        [Validation(Required=false)]
        public string ImageTerrorismFreezeConfig { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ScanImageNoFileType")]
        [Validation(Required=false)]
        public bool? ScanImageNoFileType { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("VideoAdFreezeConfig")]
        [Validation(Required=false)]
        public string VideoAdFreezeConfig { get; set; }

        [NameInMap("VideoAutoFreezeOpened")]
        [Validation(Required=false)]
        public bool? VideoAutoFreezeOpened { get; set; }

        [NameInMap("VideoAutoFreezeSceneList")]
        [Validation(Required=false)]
        public string VideoAutoFreezeSceneList { get; set; }

        [NameInMap("VideoFrameInterval")]
        [Validation(Required=false)]
        public int? VideoFrameInterval { get; set; }

        [NameInMap("VideoLiveFreezeConfig")]
        [Validation(Required=false)]
        public string VideoLiveFreezeConfig { get; set; }

        [NameInMap("VideoMaxFrames")]
        [Validation(Required=false)]
        public int? VideoMaxFrames { get; set; }

        [NameInMap("VideoMaxSize")]
        [Validation(Required=false)]
        public int? VideoMaxSize { get; set; }

        [NameInMap("VideoPornFreezeConfig")]
        [Validation(Required=false)]
        public string VideoPornFreezeConfig { get; set; }

        [NameInMap("VideoScanLimit")]
        [Validation(Required=false)]
        public long? VideoScanLimit { get; set; }

        [NameInMap("VideoSceneList")]
        [Validation(Required=false)]
        public string VideoSceneList { get; set; }

        [NameInMap("VideoTerrorismFreezeConfig")]
        [Validation(Required=false)]
        public string VideoTerrorismFreezeConfig { get; set; }

        [NameInMap("VideoVoiceAntispamFreezeConfig")]
        [Validation(Required=false)]
        public string VideoVoiceAntispamFreezeConfig { get; set; }

    }

}
