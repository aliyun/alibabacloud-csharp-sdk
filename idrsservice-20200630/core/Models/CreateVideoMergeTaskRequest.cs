// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class CreateVideoMergeTaskRequest : TeaModel {
        [NameInMap("VideoMergeRequest")]
        [Validation(Required=false)]
        public CreateVideoMergeTaskRequestVideoMergeRequest VideoMergeRequest { get; set; }
        public class CreateVideoMergeTaskRequestVideoMergeRequest : TeaModel {
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            [NameInMap("LayoutStyles")]
            [Validation(Required=false)]
            public List<CreateVideoMergeTaskRequestVideoMergeRequestLayoutStyles> LayoutStyles { get; set; }
            public class CreateVideoMergeTaskRequestVideoMergeRequestLayoutStyles : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                [NameInMap("InputNum")]
                [Validation(Required=false)]
                public long? InputNum { get; set; }

                [NameInMap("VideoStyles")]
                [Validation(Required=false)]
                public List<CreateVideoMergeTaskRequestVideoMergeRequestLayoutStylesVideoStyles> VideoStyles { get; set; }
                public class CreateVideoMergeTaskRequestVideoMergeRequestLayoutStylesVideoStyles : TeaModel {
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public long? Height { get; set; }

                    [NameInMap("PositionX")]
                    [Validation(Required=false)]
                    public long? PositionX { get; set; }

                    [NameInMap("PositionY")]
                    [Validation(Required=false)]
                    public long? PositionY { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public long? Width { get; set; }

                }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

            [NameInMap("VideoList")]
            [Validation(Required=false)]
            public List<CreateVideoMergeTaskRequestVideoMergeRequestVideoList> VideoList { get; set; }
            public class CreateVideoMergeTaskRequestVideoMergeRequestVideoList : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                [NameInMap("MergeBeginTime")]
                [Validation(Required=false)]
                public long? MergeBeginTime { get; set; }

                [NameInMap("MergeEndTime")]
                [Validation(Required=false)]
                public long? MergeEndTime { get; set; }

                [NameInMap("PrimeVideo")]
                [Validation(Required=false)]
                public bool? PrimeVideo { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public CreateVideoMergeTaskRequestVideoMergeRequestWatermark Watermark { get; set; }
            public class CreateVideoMergeTaskRequestVideoMergeRequestWatermark : TeaModel {
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public long? FontSize { get; set; }

                [NameInMap("PositionX")]
                [Validation(Required=false)]
                public long? PositionX { get; set; }

                [NameInMap("PositionY")]
                [Validation(Required=false)]
                public long? PositionY { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

        }

    }

}
