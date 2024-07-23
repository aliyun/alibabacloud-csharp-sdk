// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitPackageJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<SubmitPackageJobRequestInputs> Inputs { get; set; }
        public class SubmitPackageJobRequestInputs : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitPackageJobRequestInputsInput Input { get; set; }
            public class SubmitPackageJobRequestInputsInput : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitPackageJobRequestOutput Output { get; set; }
        public class SubmitPackageJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/path/to/video.mp4</para>
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

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitPackageJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitPackageJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;param&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
