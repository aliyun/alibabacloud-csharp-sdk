// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDynamicImageJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestInput Input { get; set; }
        public class SubmitDynamicImageJobRequestInput : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object.mp4</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SampleJob</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestOutput Output { get; set; }
        public class SubmitDynamicImageJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitDynamicImageJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestTemplateConfig TemplateConfig { get; set; }
        public class SubmitDynamicImageJobRequestTemplateConfig : TeaModel {
            [NameInMap("OverwriteParams")]
            [Validation(Required=false)]
            public SubmitDynamicImageJobRequestTemplateConfigOverwriteParams OverwriteParams { get; set; }
            public class SubmitDynamicImageJobRequestTemplateConfigOverwriteParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>gif</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public int? Fps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LongShortMode")]
                [Validation(Required=false)]
                public bool? LongShortMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>progressive</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;SampleKey&quot;: &quot;SampleValue&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
