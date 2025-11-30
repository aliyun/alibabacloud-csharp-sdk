// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertJobFeature : TeaModel {
        [NameInMap("Clip")]
        [Validation(Required=false)]
        public MediaConvertJobFeatureClip Clip { get; set; }
        public class MediaConvertJobFeatureClip : TeaModel {
            [NameInMap("ConfigToClipFirstPart")]
            [Validation(Required=false)]
            public string ConfigToClipFirstPart { get; set; }

            [NameInMap("TimeSpan")]
            [Validation(Required=false)]
            public MediaConvertJobFeatureClipTimeSpan TimeSpan { get; set; }
            public class MediaConvertJobFeatureClipTimeSpan : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                [NameInMap("Seek")]
                [Validation(Required=false)]
                public string Seek { get; set; }

            }

        }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<MediaConvertJobFeatureWatermarks> Watermarks { get; set; }
        public class MediaConvertJobFeatureWatermarks : TeaModel {
            [NameInMap("Adaptive")]
            [Validation(Required=false)]
            public string Adaptive { get; set; }

            [NameInMap("BorderColor")]
            [Validation(Required=false)]
            public string BorderColor { get; set; }

            [NameInMap("BorderWidth")]
            [Validation(Required=false)]
            public string BorderWidth { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("FontAlpha")]
            [Validation(Required=false)]
            public string FontAlpha { get; set; }

            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public string FontColor { get; set; }

            [NameInMap("FontName")]
            [Validation(Required=false)]
            public string FontName { get; set; }

            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public string FontSize { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public string X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public string Y { get; set; }

        }

    }

}
