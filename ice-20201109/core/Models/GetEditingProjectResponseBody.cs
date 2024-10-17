// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetEditingProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the online editing project.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public GetEditingProjectResponseBodyProject Project { get; set; }
        public class GetEditingProjectResponseBodyProject : TeaModel {
            /// <summary>
            /// <para>The business configuration of the project. This parameter can be ignored for general editing projects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;OutputMediaConfig&quot; : { &quot;StorageLocation&quot;: &quot;test-bucket.oss-cn-shanghai.aliyuncs.com&quot;, &quot;Path&quot;: &quot;test-path&quot; }, &quot;OutputMediaTarget&quot;: &quot;oss-object&quot;, &quot;ReservationTime&quot;: &quot;2021-06-21T08:05:00Z&quot; }</para>
            /// </summary>
            [NameInMap("BusinessConfig")]
            [Validation(Required=false)]
            public string BusinessConfig { get; set; }

            /// <summary>
            /// <para>The business status of the project. This parameter can be ignored for general editing projects. Valid values:</para>
            /// <para>Reserving</para>
            /// <para>ReservationCanceled</para>
            /// <para>BroadCasting</para>
            /// <para>LoadingFailed</para>
            /// <para>LiveFinished</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserving</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The material parameter corresponding to the template, in the JSON format. If TemplateId is specified, ClipsParam must also be specified. For more information&lt;props=&quot;china&quot;&gt;, see <a href="https://help.aliyun.com/document_detail/328557.html">Create and use a regular template</a> and <a href="https://help.aliyun.com/document_detail/291418.html">Create and use an advanced template</a>.</para>
            /// </summary>
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }

            /// <summary>
            /// <para>The thumbnail URL of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://example-bucket/example.jpg</para>
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
            /// <para>OpenAPI</para>
            /// </summary>
            [NameInMap("CreateSource")]
            [Validation(Required=false)]
            public string CreateSource { get; set; }

            /// <summary>
            /// <para>The time when the online editing project was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-20T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the online editing project.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The total duration of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24.120000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The method for editing the online editing project. Valid values:</para>
            /// <para>\- OpenAPI</para>
            /// <para>\- AliyunConsole</para>
            /// <para>\- WebSDK</para>
            /// <para>\- LiveEditingOpenAPI</para>
            /// <para>\- LiveEditingConsole</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI</para>
            /// </summary>
            [NameInMap("ModifiedSource")]
            [Validation(Required=false)]
            public string ModifiedSource { get; set; }

            /// <summary>
            /// <para>The time when the online editing project was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-20T13:00:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>fb2101bf24b2754cb318787dc</b></b></para>
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
            /// <para>EditingProject</para>
            /// </summary>
            [NameInMap("ProjectType")]
            [Validation(Required=false)]
            public string ProjectType { get; set; }

            /// <summary>
            /// <para>The status of the online editing project. Valid values:</para>
            /// <para>\- Draft</para>
            /// <para>\- Editing</para>
            /// <para>\- Producing</para>
            /// <para>\- Produced</para>
            /// <para>\- ProduceFailed</para>
            /// <para>\- Deleted</para>
            /// 
            /// <b>Example:</b>
            /// <para>Editing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
            /// <para>The timeline of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>9b4d7cf14dc7b83b0e801cbe</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>9b4d7cf14dc7b83b0e801cbe</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>1656bca4474999c961a6d2a2</b></b>&quot;}]}]}</para>
            /// </summary>
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public string Timeline { get; set; }

            /// <summary>
            /// <para>The error message returned if the project conversion failed. The error message displays the detailed information about the failure, and is returned only if the value of TimelineConvertStatus is ConvertFailed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The StorageLocation must be in the same division(apiRegion) as ICE service access point.</para>
            /// </summary>
            [NameInMap("TimelineConvertErrorMessage")]
            [Validation(Required=false)]
            public string TimelineConvertErrorMessage { get; set; }

            /// <summary>
            /// <para>The project conversion status. Conversion of an API-style timeline into a frontend-style timeline is an asynchronous process and takes effect only if RequestSource:WebSDK is specified.</para>
            /// <para>\- Unconverted</para>
            /// <para>\- Converting</para>
            /// <para>\- Converted</para>
            /// <para>\- ConvertFailed</para>
            /// 
            /// <b>Example:</b>
            /// <para>Converted</para>
            /// </summary>
            [NameInMap("TimelineConvertStatus")]
            [Validation(Required=false)]
            public string TimelineConvertStatus { get; set; }

            /// <summary>
            /// <para>The title of the online editing project.</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
