// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateEditingProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the online editing project.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public CreateEditingProjectResponseBodyProject Project { get; set; }
        public class CreateEditingProjectResponseBodyProject : TeaModel {
            /// <summary>
            /// <para>The business configuration of the project. This parameter can be ignored for general editing projects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;OutputMediaConfig&quot; :    { &quot;StorageLocation&quot;: &quot;test-bucket.oss-cn-shanghai.aliyuncs.com&quot;, &quot;Path&quot;: &quot;test-path&quot;   }, &quot;OutputMediaTarget&quot;: &quot;oss-object&quot;, &quot;ReservationTime&quot;: &quot;2021-06-21T08:05:00Z&quot; }</para>
            /// </summary>
            [NameInMap("BusinessConfig")]
            [Validation(Required=false)]
            public string BusinessConfig { get; set; }

            /// <summary>
            /// <para>The business status of the project. This parameter can be ignored for general editing projects. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Reserving</description></item>
            /// <item><description>ReservationCanceled</description></item>
            /// <item><description>BroadCasting</description></item>
            /// <item><description>LoadingFailed</description></item>
            /// <item><description>LiveFinished</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Reserving</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The template material parameters.</para>
            /// </summary>
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }

            /// <summary>
            /// <para>The thumbnail URL of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The method for creating the online editing project. Valid values:</para>
            /// <para>\- OpenAPI</para>
            /// <para>\- AliyunConsole</para>
            /// <para>\- WebSDK</para>
            /// <para>\- LiveEditingOpenAPI</para>
            /// <para>\- LiveEditingConsole</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebSDK</para>
            /// </summary>
            [NameInMap("CreateSource")]
            [Validation(Required=false)]
            public string CreateSource { get; set; }

            /// <summary>
            /// <para>The time when the online editing project was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-08T16:52:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The duration of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.4200000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The method for editing the online editing project. Valid values:</para>
            /// <para>\- OpenAPI</para>
            /// <para>\- AliyunConsole</para>
            /// <para>\- WebSDK</para>
            /// <para>\- LiveEditingOpenAPI</para>
            /// <para>\- LiveEditingConsole</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebSDK</para>
            /// </summary>
            [NameInMap("ModifiedSource")]
            [Validation(Required=false)]
            public string ModifiedSource { get; set; }

            /// <summary>
            /// <para>The time when the online editing project was last edited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-08T16:52:07Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>01bf24bf41c78b2754cb3187</b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The type of the editing project. Default value: EditingProject. Valid values:</para>
            /// <para>\- EditingProject: a regular editing project.</para>
            /// <para>\- LiveEditingProject: a live stream editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LiveEditingProject</para>
            /// </summary>
            [NameInMap("ProjectType")]
            [Validation(Required=false)]
            public string ProjectType { get; set; }

            /// <summary>
            /// <para>The status of the online editing project.</para>
            /// <para>Valid values:</para>
            /// <para>\- 1: Draft</para>
            /// <para>\- 2: Editing</para>
            /// <para>\- 3: Producing</para>
            /// <para>\- 4: Produced</para>
            /// <para>\- 5: ProduceFailed</para>
            /// <para>\- 7: Deleted</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The status of the online editing project. For more information, see the status list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Editing</para>
            /// </summary>
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template type of the online editing project. Valid values:</para>
            /// <para>\- Timeline</para>
            /// <para>\- VETemplate</para>
            /// 
            /// <b>Example:</b>
            /// <para>Timeline</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The timeline of the online editing project, in the JSON format.&lt;props=&quot;china&quot;&gt;For more information about objects in a timeline, see <a href="https://help.aliyun.com/document_detail/198823.htm?spm=a2c4g.11186623.2.9.90dc653dF67srN#topic-2024662">Timeline configurations</a>.  If you leave this parameter empty, an empty timeline is created and the duration of the online editing project is zero.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
            /// </summary>
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public string Timeline { get; set; }

            /// <summary>
            /// <para>The title of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
