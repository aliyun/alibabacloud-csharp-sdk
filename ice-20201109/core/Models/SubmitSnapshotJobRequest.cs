// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSnapshotJobRequest : TeaModel {
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestInput Input { get; set; }
        public class SubmitSnapshotJobRequestInput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestOutput Output { get; set; }
        public class SubmitSnapshotJobRequestOutput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitSnapshotJobRequestScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
        };

        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestTemplateConfig TemplateConfig { get; set; }
        public class SubmitSnapshotJobRequestTemplateConfig : TeaModel {
            [NameInMap("OverwriteParams")]
            [Validation(Required=false)]
            public SubmitSnapshotJobRequestTemplateConfigOverwriteParams OverwriteParams { get; set; }
            public class SubmitSnapshotJobRequestTemplateConfigOverwriteParams : TeaModel {
                [NameInMap("BlackLevel")]
                [Validation(Required=false)]
                public int? BlackLevel { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("FrameType")]
                [Validation(Required=false)]
                public string FrameType { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                [NameInMap("IsSptFrag")]
                [Validation(Required=false)]
                public bool? IsSptFrag { get; set; }

                [NameInMap("PixelBlackThreshold")]
                [Validation(Required=false)]
                public int? PixelBlackThreshold { get; set; }

                [NameInMap("SpriteSnapshotConfig")]
                [Validation(Required=false)]
                public SubmitSnapshotJobRequestTemplateConfigOverwriteParamsSpriteSnapshotConfig SpriteSnapshotConfig { get; set; }
                public class SubmitSnapshotJobRequestTemplateConfigOverwriteParamsSpriteSnapshotConfig : TeaModel {
                    [NameInMap("CellHeight")]
                    [Validation(Required=false)]
                    public int? CellHeight { get; set; }
                    [NameInMap("CellWidth")]
                    [Validation(Required=false)]
                    public int? CellWidth { get; set; }
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public int? Columns { get; set; }
                    [NameInMap("Lines")]
                    [Validation(Required=false)]
                    public int? Lines { get; set; }
                    [NameInMap("Margin")]
                    [Validation(Required=false)]
                    public int? Margin { get; set; }
                    [NameInMap("Padding")]
                    [Validation(Required=false)]
                    public int? Padding { get; set; }
                };

                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
        };

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
