// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDynamicImageJobRequest : TeaModel {
        /// <summary>
        /// <para>The input of the job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestInput Input { get; set; }
        public class SubmitDynamicImageJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The input file. If Type is set to OSS, set this parameter to the URL of an OSS object. If Type is set to Media, set this parameter to the ID of a media asset. The URL of an OSS object can be in one of the following formats:</para>
            /// <ol>
            /// <item><description>oss://bucket/object</description></item>
            /// <item><description>http(s)://bucket.oss-[RegionId].aliyuncs.com/object</description></item>
            /// </ol>
            /// <para>In the URL, bucket specifies an OSS bucket that resides in the same region as the job, and object specifies the object URL in OSS.</para>
            /// <remarks>
            /// <para> Before you use the OSS bucket in the URL, you must add the bucket on the <a href="https://help.aliyun.com/document_detail/609918.html">Storage Management</a> page of the Intelligent Media Services (IMS) console.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object.mp4</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input file. Valid values:</para>
            /// <ol>
            /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
            /// <item><description>Media: a media asset.</description></item>
            /// </ol>
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
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleJob</para>
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
        public SubmitDynamicImageJobRequestOutput Output { get; set; }
        public class SubmitDynamicImageJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The output file. The file can be an OSS object or a media asset. The URL of an OSS object can be in one of the following formats:</para>
            /// <list type="bullet">
            /// <item><description>oss://bucket/object</description></item>
            /// <item><description>http(s)://bucket.oss-[regionId].aliyuncs.com/object</description></item>
            /// </list>
            /// <para>In the URL, bucket specifies an OSS bucket that resides in the same region as the job, and object specifies the object URL in OSS.</para>
            /// <remarks>
            /// <para> Before you use the OSS bucket in the URL, you must add the bucket on the <a href="https://help.aliyun.com/document_detail/609918.html">Storage Management</a> page of the IMS console.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the output file. Valid values:</para>
            /// <ol>
            /// <item><description>OSS: an OSS object.</description></item>
            /// <item><description>Media: a media asset.</description></item>
            /// </ol>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Media</para>
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
        public SubmitDynamicImageJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitDynamicImageJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the MPS queue to which the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority. Valid values: 1 to 10. Default value: 6. A greater value specifies a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The snapshot template configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestTemplateConfig TemplateConfig { get; set; }
        public class SubmitDynamicImageJobRequestTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The parameters that are used to overwrite the corresponding parameters.</para>
            /// </summary>
            [NameInMap("OverwriteParams")]
            [Validation(Required=false)]
            public SubmitDynamicImageJobRequestTemplateConfigOverwriteParams OverwriteParams { get; set; }
            public class SubmitDynamicImageJobRequestTemplateConfigOverwriteParams : TeaModel {
                /// <summary>
                /// <para>The format of the animated image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>gif</b></description></item>
                /// <item><description><b>webp</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>gif</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The frame rate. Valid values: [1,60].</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public int? Fps { get; set; }

                /// <summary>
                /// <para>The height of the animated image. Valid values: [128,4096].</para>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the auto-rotate screen feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <para>Default value: <b>true</b>.</para>
                /// <remarks>
                /// <para> If this feature is enabled, the width of the output video corresponds to the long side of the input video, which is the height of the input video in portrait mode. The height of the output video corresponds to the short side of the input video, which is the width of the input video in portrait mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LongShortMode")]
                [Validation(Required=false)]
                public bool? LongShortMode { get; set; }

                /// <summary>
                /// <para>The scan mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>interlaced</b></description></item>
                /// <item><description><b>progressive</b> This is the default value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>progressive</para>
                /// </summary>
                [NameInMap("ScanMode")]
                [Validation(Required=false)]
                public string ScanMode { get; set; }

                /// <summary>
                /// <para>The timeline parameters.</para>
                /// </summary>
                [NameInMap("TimeSpan")]
                [Validation(Required=false)]
                public SubmitDynamicImageJobRequestTemplateConfigOverwriteParamsTimeSpan TimeSpan { get; set; }
                public class SubmitDynamicImageJobRequestTemplateConfigOverwriteParamsTimeSpan : TeaModel {
                    /// <summary>
                    /// <para>The length of the clip.</para>
                    /// <list type="bullet">
                    /// <item><description>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</description></item>
                    /// <item><description>Valid values: <c>[00:00:00.000,23:59:59.999]</c> or <c>[0.000,86399.999]</c>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01:59:59.999 or 32000.23</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The length of the ending part of the original clip to be cropped out. If you specify this parameter, the Duration parameter becomes invalid.</para>
                    /// <list type="bullet">
                    /// <item><description>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</description></item>
                    /// <item><description>Valid values: <c>[00:00:00.000,23:59:59.999]</c> or <c>[0.000,86399.999]</c>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01:59:59.999 or 32000.23</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public string End { get; set; }

                    /// <summary>
                    /// <para>The start point of the clip.</para>
                    /// <list type="bullet">
                    /// <item><description>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</description></item>
                    /// <item><description>Valid values: <c>[00:00:00.000,23:59:59.999]</c> or <c>[0.000,86399.999]</c>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01:59:59.999 or 32000.23</para>
                    /// </summary>
                    [NameInMap("Seek")]
                    [Validation(Required=false)]
                    public string Seek { get; set; }

                }

                /// <summary>
                /// <para>The width of the animated image. Valid values: [128,4096].</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>The template ID.</para>
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
        /// <para>The user-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SampleKey&quot;: &quot;SampleValue&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
