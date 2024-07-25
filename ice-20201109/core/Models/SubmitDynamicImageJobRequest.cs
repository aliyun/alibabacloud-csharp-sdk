// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDynamicImageJobRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestInput Input { get; set; }
        public class SubmitDynamicImageJobRequestInput : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestOutput Output { get; set; }
        public class SubmitDynamicImageJobRequestOutput : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitDynamicImageJobRequestScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestTemplateConfig TemplateConfig { get; set; }
        public class SubmitDynamicImageJobRequestTemplateConfig : TeaModel {
            [NameInMap("OverwriteParams")]
            [Validation(Required=false)]
            public SubmitDynamicImageJobRequestTemplateConfigOverwriteParams OverwriteParams { get; set; }
            public class SubmitDynamicImageJobRequestTemplateConfigOverwriteParams : TeaModel {
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public int? Fps { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("LongShortMode")]
                [Validation(Required=false)]
                public bool? LongShortMode { get; set; }

                [NameInMap("ScanMode")]
                [Validation(Required=false)]
                public string ScanMode { get; set; }

                [NameInMap("TimeSpan")]
                [Validation(Required=false)]
                public SubmitDynamicImageJobRequestTemplateConfigOverwriteParamsTimeSpan TimeSpan { get; set; }
                public class SubmitDynamicImageJobRequestTemplateConfigOverwriteParamsTimeSpan : TeaModel {
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

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
