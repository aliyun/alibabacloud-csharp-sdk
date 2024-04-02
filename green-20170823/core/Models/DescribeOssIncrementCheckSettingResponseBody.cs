// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeOssIncrementCheckSettingResponseBody : TeaModel {
        [NameInMap("AudioAntispamFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyAudioAntispamFreezeConfig AudioAntispamFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyAudioAntispamFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
        public List<string> AudioSceneList { get; set; }

        [NameInMap("AutoFreezeType")]
        [Validation(Required=false)]
        public string AutoFreezeType { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BizTypeTemplate")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplate BizTypeTemplate { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplate : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ImageConfig")]
            [Validation(Required=false)]
            public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfig ImageConfig { get; set; }
            public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfig : TeaModel {
                [NameInMap("Ad")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfigAd Ad { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfigAd : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

                [NameInMap("Live")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfigLive Live { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfigLive : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

                [NameInMap("Porn")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfigPorn Porn { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfigPorn : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

                [NameInMap("Terrorism")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfigTerrorism Terrorism { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateImageConfigTerrorism : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

            }

            [NameInMap("IncludeChannel")]
            [Validation(Required=false)]
            public int? IncludeChannel { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("VideoConfig")]
            [Validation(Required=false)]
            public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfig VideoConfig { get; set; }
            public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfig : TeaModel {
                [NameInMap("Ad")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfigAd Ad { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfigAd : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

                [NameInMap("Live")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfigLive Live { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfigLive : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

                [NameInMap("Porn")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfigPorn Porn { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfigPorn : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

                [NameInMap("Terrorism")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfigTerrorism Terrorism { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVideoConfigTerrorism : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

            }

            [NameInMap("VoiceConfig")]
            [Validation(Required=false)]
            public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVoiceConfig VoiceConfig { get; set; }
            public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVoiceConfig : TeaModel {
                [NameInMap("Antispam")]
                [Validation(Required=false)]
                public DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVoiceConfigAntispam Antispam { get; set; }
                public class DescribeOssIncrementCheckSettingResponseBodyBizTypeTemplateVoiceConfigAntispam : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<string> Categories { get; set; }

                }

            }

        }

        [NameInMap("BucketConfigList")]
        [Validation(Required=false)]
        public List<DescribeOssIncrementCheckSettingResponseBodyBucketConfigList> BucketConfigList { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyBucketConfigList : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("Prefixes")]
            [Validation(Required=false)]
            public List<string> Prefixes { get; set; }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public bool? Selected { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("CallbackId")]
        [Validation(Required=false)]
        public string CallbackId { get; set; }

        [NameInMap("CallbackName")]
        [Validation(Required=false)]
        public string CallbackName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ImageAdFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyImageAdFreezeConfig ImageAdFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyImageAdFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ImageAutoFreeze")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyImageAutoFreeze ImageAutoFreeze { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyImageAutoFreeze : TeaModel {
            [NameInMap("Ad")]
            [Validation(Required=false)]
            public string Ad { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Live")]
            [Validation(Required=false)]
            public string Live { get; set; }

            [NameInMap("Porn")]
            [Validation(Required=false)]
            public string Porn { get; set; }

            [NameInMap("Terrorism")]
            [Validation(Required=false)]
            public string Terrorism { get; set; }

        }

        [NameInMap("ImageAutoFreezeOpened")]
        [Validation(Required=false)]
        public bool? ImageAutoFreezeOpened { get; set; }

        [NameInMap("ImageEnableLimit")]
        [Validation(Required=false)]
        public bool? ImageEnableLimit { get; set; }

        [NameInMap("ImageLiveFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyImageLiveFreezeConfig ImageLiveFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyImageLiveFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ImagePornFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyImagePornFreezeConfig ImagePornFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyImagePornFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ImageScanLimit")]
        [Validation(Required=false)]
        public long? ImageScanLimit { get; set; }

        [NameInMap("ImageSceneList")]
        [Validation(Required=false)]
        public List<string> ImageSceneList { get; set; }

        [NameInMap("ImageTerrorismFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyImageTerrorismFreezeConfig ImageTerrorismFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyImageTerrorismFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScanImageNoFileType")]
        [Validation(Required=false)]
        public bool? ScanImageNoFileType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("VideoAdFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyVideoAdFreezeConfig VideoAdFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyVideoAdFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VideoAutoFreezeOpened")]
        [Validation(Required=false)]
        public bool? VideoAutoFreezeOpened { get; set; }

        [NameInMap("VideoAutoFreezeSceneList")]
        [Validation(Required=false)]
        public List<string> VideoAutoFreezeSceneList { get; set; }

        [NameInMap("VideoFrameInterval")]
        [Validation(Required=false)]
        public int? VideoFrameInterval { get; set; }

        [NameInMap("VideoLiveFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyVideoLiveFreezeConfig VideoLiveFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyVideoLiveFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VideoMaxFrames")]
        [Validation(Required=false)]
        public int? VideoMaxFrames { get; set; }

        [NameInMap("VideoMaxSize")]
        [Validation(Required=false)]
        public int? VideoMaxSize { get; set; }

        [NameInMap("VideoPornFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyVideoPornFreezeConfig VideoPornFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyVideoPornFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VideoScanLimit")]
        [Validation(Required=false)]
        public long? VideoScanLimit { get; set; }

        [NameInMap("VideoSceneList")]
        [Validation(Required=false)]
        public List<string> VideoSceneList { get; set; }

        [NameInMap("VideoTerrorismFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyVideoTerrorismFreezeConfig VideoTerrorismFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyVideoTerrorismFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VideoVoiceAntispamFreezeConfig")]
        [Validation(Required=false)]
        public DescribeOssIncrementCheckSettingResponseBodyVideoVoiceAntispamFreezeConfig VideoVoiceAntispamFreezeConfig { get; set; }
        public class DescribeOssIncrementCheckSettingResponseBodyVideoVoiceAntispamFreezeConfig : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
