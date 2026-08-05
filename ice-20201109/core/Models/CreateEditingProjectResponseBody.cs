// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateEditingProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud editing project.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public CreateEditingProjectResponseBodyProject Project { get; set; }
        public class CreateEditingProjectResponseBodyProject : TeaModel {
            /// <summary>
            /// <para>The business configuration of the project. This parameter can be ignored for standard editing projects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;OutputMediaConfig&quot; :    { &quot;StorageLocation&quot;: &quot;test-bucket.oss-cn-shanghai.aliyuncs.com&quot;, &quot;Path&quot;: &quot;test-path&quot;   }, &quot;OutputMediaTarget&quot;: &quot;oss-object&quot;, &quot;ReservationTime&quot;: &quot;2021-06-21T08:05:00Z&quot; }</para>
            /// </summary>
            [NameInMap("BusinessConfig")]
            [Validation(Required=false)]
            public string BusinessConfig { get; set; }

            /// <summary>
            /// <para>The business status of the project. This parameter can be ignored for standard editing projects.</para>
            /// <list type="bullet">
            /// <item><description>Reserving: The live stream is being reserved.</description></item>
            /// <item><description>ReservationCanceled: The reservation is canceled. </description></item>
            /// <item><description>BroadCasting: The live stream is broadcasting.</description></item>
            /// <item><description>LoadingFailed: Loading failed.</description></item>
            /// <item><description>LiveFinished: The live stream has ended.</description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>See the template user guide.</para>
            /// </summary>
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }

            /// <summary>
            /// <para>The cover URL of the cloud editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The creation source of the cloud editing project.</para>
            /// <list type="bullet">
            /// <item><description><para>OpenAPI</para>
            /// </description></item>
            /// <item><description><para>AliyunConsole</para>
            /// </description></item>
            /// <item><description><para>WebSDK</para>
            /// </description></item>
            /// <item><description><para>LiveEditingOpenAPI </para>
            /// </description></item>
            /// <item><description><para>LiveEditingConsole</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WebSDK</para>
            /// </summary>
            [NameInMap("CreateSource")]
            [Validation(Required=false)]
            public string CreateSource { get; set; }

            /// <summary>
            /// <para>The creation time of the cloud editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-08T16:52:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The duration of the cloud editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.4200000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The modification source of the cloud editing project.</para>
            /// <list type="bullet">
            /// <item><description>OpenAPI</description></item>
            /// <item><description>AliyunConsole</description></item>
            /// <item><description>WebSDK</description></item>
            /// <item><description>LiveEditingOpenAPI </description></item>
            /// <item><description>LiveEditingConsole</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WebSDK</para>
            /// </summary>
            [NameInMap("ModifiedSource")]
            [Validation(Required=false)]
            public string ModifiedSource { get; set; }

            /// <summary>
            /// <para>The modification time of the cloud editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-08T16:52:07Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the cloud editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>01bf24bf41c78b2754cb3187</b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The type of the editing project. Default value: EditingProject.</para>
            /// <list type="bullet">
            /// <item><description><para>EditingProject: standard editing project.</para>
            /// </description></item>
            /// <item><description><para>LiveEditingProject: live editing project.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LiveEditingProject</para>
            /// </summary>
            [NameInMap("ProjectType")]
            [Validation(Required=false)]
            public string ProjectType { get; set; }

            /// <summary>
            /// <para>The status of the cloud editing project.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Draft.</para>
            /// </description></item>
            /// <item><description><para>2: Editing.</para>
            /// </description></item>
            /// <item><description><para>3: Producing.</para>
            /// </description></item>
            /// <item><description><para>4: Produced.</para>
            /// </description></item>
            /// <item><description><para>5: ProduceFailed.</para>
            /// </description></item>
            /// <item><description><para>7: Deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The status name of the cloud editing project, corresponding to the status name in the status list.</para>
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
            /// <para>The template type of the cloud editing project.</para>
            /// <list type="bullet">
            /// <item><description><para>Timeline</para>
            /// </description></item>
            /// <item><description><para>VETemplate</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Timeline</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The timeline of the cloud editing project in JSON format. For more information about the structure, see <a href="~~198823#topic-2024662~~">TimeLine</a>. If this field is empty, an empty timeline is created and the total duration of the cloud editing project is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
            /// </summary>
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public string Timeline { get; set; }

            /// <summary>
            /// <para>The title of the cloud editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
