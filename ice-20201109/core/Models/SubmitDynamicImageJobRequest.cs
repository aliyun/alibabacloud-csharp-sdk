// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDynamicImageJobRequest : TeaModel {
        /// <summary>
        /// <para>The job input.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestInput Input { get; set; }
        public class SubmitDynamicImageJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The input media resource.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>Type</c> is set to <c>OSS</c>, specify the OSS URL of the input file.</para>
            /// </description></item>
            /// <item><description><para>If <c>Type</c> is set to <c>Media</c>, specify the media asset ID.</para>
            /// </description></item>
            /// </list>
            /// <para>An OSS URL must be in one of the following formats:</para>
            /// <ol>
            /// <item><description><para><c>oss://bucket/object</c></para>
            /// </description></item>
            /// <item><description><para><c>http(s)://bucket.oss-[RegionId].aliyuncs.com/object</c></para>
            /// </description></item>
            /// </ol>
            /// <para>In these formats, <c>bucket</c> is the name of an OSS bucket in the same region as the current project, and <c>object</c> is the file path.</para>
            /// <remarks>
            /// <para>The specified OSS bucket must be registered in IMS <a href="https://help.aliyun.com/document_detail/609918.html">storage management</a>.</para>
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
            /// <para>The type of the job input. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>OSS</c>: An Object Storage Service (OSS) file URL.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: A media asset ID.</para>
            /// </description></item>
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
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleJob</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The job output.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestOutput Output { get; set; }
        public class SubmitDynamicImageJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The destination OSS URL for the output file. This parameter is required when <c>Type</c> is set to <c>OSS</c>. The URL must be in one of the following formats:</para>
            /// <list type="bullet">
            /// <item><description><para><c>oss://bucket/object</c></para>
            /// </description></item>
            /// <item><description><para><c>http(s)://bucket.oss-[regionId].aliyuncs.com/object</c></para>
            /// </description></item>
            /// </list>
            /// <para>In these formats, <c>bucket</c> is the name of an OSS bucket in the same region as the current project, and <c>object</c> is the file path.</para>
            /// <remarks>
            /// <para>The specified OSS bucket must be registered in IMS <a href="https://help.aliyun.com/document_detail/609918.html">storage management</a>.</para>
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
            /// <para>The type of the job output. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>OSS</c>: The output is an OSS file.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: The output is a new media asset.</para>
            /// </description></item>
            /// </list>
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
        /// <para>The scheduling configuration.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitDynamicImageJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority of the job. Valid range: [1, 10]. A higher value indicates a higher priority. Default value: 6.</para>
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
            /// <para>The overwrite parameters.</para>
            /// </summary>
            [NameInMap("OverwriteParams")]
            [Validation(Required=false)]
            public SubmitDynamicImageJobRequestTemplateConfigOverwriteParams OverwriteParams { get; set; }
            public class SubmitDynamicImageJobRequestTemplateConfigOverwriteParams : TeaModel {
                /// <summary>
                /// <para>The animated image format. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>gif</c></para>
                /// </description></item>
                /// <item><description><para><c>webp</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>gif</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The frame rate. Valid range: [1, 60].</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public int? Fps { get; set; }

                /// <summary>
                /// <para>The height of the output animated image. Valid range: [128, 4096].</para>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable adaptive orientation based on the long and short edges of the video. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enables adaptive orientation.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disables adaptive orientation.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <b>true</b>.</para>
                /// <remarks>
                /// <para>When enabled, this mode sets the output width to the source video\&quot;s long edge and the output height to its short edge. For a portrait video, its height is treated as the long edge and its width as the short edge.</para>
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
                /// <item><description><para><b>interlaced</b>: Interlaced scanning.</para>
                /// </description></item>
                /// <item><description><para><b>progressive</b>: Progressive scanning. This is the default value.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>progressive</para>
                /// </summary>
                [NameInMap("ScanMode")]
                [Validation(Required=false)]
                public string ScanMode { get; set; }

                /// <summary>
                /// <para>Specifies the time range of the video to process for the animated image.</para>
                /// </summary>
                [NameInMap("TimeSpan")]
                [Validation(Required=false)]
                public SubmitDynamicImageJobRequestTemplateConfigOverwriteParamsTimeSpan TimeSpan { get; set; }
                public class SubmitDynamicImageJobRequestTemplateConfigOverwriteParamsTimeSpan : TeaModel {
                    /// <summary>
                    /// <para>The duration of the video segment to be processed.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</para>
                    /// </description></item>
                    /// <item><description><para>Valid range: <c>[00:00:00.000,23:59:59.999]</c> or <c>[0.000,86399.999]</c>.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01:59:59.999 or 32000.23</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The end time of the video segment to be processed. If this parameter is set, the <c>Duration</c> parameter is ignored.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</para>
                    /// </description></item>
                    /// <item><description><para>Valid range: <c>[00:00:00.000,23:59:59.999]</c> or <c>[0.000,86399.999]</c>.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01:59:59.999 or 32000.23</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public string End { get; set; }

                    /// <summary>
                    /// <para>The start time of the video segment to be processed.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</para>
                    /// </description></item>
                    /// <item><description><para>Valid range: <c>[00:00:00.000,23:59:59.999]</c> or <c>[0.000,86399.999]</c>.</para>
                    /// </description></item>
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
                /// <para>The width of the output animated image. Valid range: [128, 4096].</para>
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
