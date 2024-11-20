// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitPackageJobRequest : TeaModel {
        /// <summary>
        /// <para>The input of the job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<SubmitPackageJobRequestInputs> Inputs { get; set; }
        public class SubmitPackageJobRequestInputs : TeaModel {
            /// <summary>
            /// <para>The information about the input stream file.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitPackageJobRequestInputsInput Input { get; set; }
            public class SubmitPackageJobRequestInputsInput : TeaModel {
                /// <summary>
                /// <para>The media object.</para>
                /// <list type="bullet">
                /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of the media object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </list>
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
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output of the job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitPackageJobRequestOutput Output { get; set; }
        public class SubmitPackageJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The media object. If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported. If Type is set to Media, set this parameter to the ID of a media asset.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/path/to/video.mp4</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the media object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: an OSS object.</description></item>
            /// <item><description>Media: a media asset.</description></item>
            /// </list>
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
        /// <para>The scheduling settings.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitPackageJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitPackageJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the MPS queue to which the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority of the job. Valid values: 1 to 10. The greater the value, the higher the priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The user-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;param&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
