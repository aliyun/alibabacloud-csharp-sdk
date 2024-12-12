// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchEditingProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned on a single page. The value is set to the maximum number of entries returned on each page except for the last page.</para>
        /// <para>Examples:</para>
        /// <para>Valid example: 10,10,5. Invalid example: 10,5,10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The queried online editing projects.</para>
        /// </summary>
        [NameInMap("ProjectList")]
        [Validation(Required=false)]
        public List<SearchEditingProjectResponseBodyProjectList> ProjectList { get; set; }
        public class SearchEditingProjectResponseBodyProjectList : TeaModel {
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BroadCasting:</description></item>
            /// <item><description>ReservationCanceled</description></item>
            /// <item><description>LiveFinished</description></item>
            /// <item><description>LoadingFailed</description></item>
            /// <item><description>Reserving</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Reserving</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The thumbnail URL of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example-cover.jpg">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example-cover.jpg</a></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The method for editing the online editing project.</para>
            /// <para>\-OpenAPI</para>
            /// <para>\-AliyunConsole</para>
            /// <para>\-WebSDK</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AliyunConsole: The project is created in the Alibaba Cloud console.</description></item>
            /// <item><description>WebSDK: The project is created by using the SDK for Web.</description></item>
            /// <item><description>OpenAPI: The project is created by calling API operations.</description></item>
            /// </list>
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
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sample description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The total length of the online editing project. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.100000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The error code returned if the production of the online editing project failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned if the production of the online editing project failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;EventTime&quot;:&quot;2021-08-12T10:04:15Z&quot;,&quot;ErrorCode&quot;:&quot;InvalidParameter&quot;,&quot;ErrorMessage&quot;:&quot;The specified parameter \&quot;LiveStreamConfig\&quot; is not valid. specified parameter example is not valid.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The method used when the online editing project was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("ModifiedSource")]
            [Validation(Required=false)]
            public string ModifiedSource { get; set; }

            /// <summary>
            /// <para>The time when the online editing project was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The type of the editing project.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LiveEditingProject: a live stream editing project.</description></item>
            /// <item><description>EditingProject: a regular editing project.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EditingProject</para>
            /// </summary>
            [NameInMap("ProjectType")]
            [Validation(Required=false)]
            public string ProjectType { get; set; }

            /// <summary>
            /// <para>The status of the online editing project. Valid values:</para>
            /// <para>\-Draft</para>
            /// <para>\-Editing</para>
            /// <para>\-Producing</para>
            /// <para>\-Produced</para>
            /// <para>\-ProduceFailed</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Draft</description></item>
            /// <item><description>Produced</description></item>
            /// <item><description>Editing</description></item>
            /// <item><description>Producing</description></item>
            /// <item><description>ProduceFailed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRODUCE_FAILED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the template.</para>
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
            /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
            /// </summary>
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public string Timeline { get; set; }

            /// <summary>
            /// <para>The title of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>9262E3DA-07FA-4862-FCBB6BC61D08</b></b>*</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Optional. The total number of entries returned. By default, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
