// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListEditingProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nzv3rcKla9wHUGua9YXHNA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The queried online editing projects.</para>
        /// </summary>
        [NameInMap("ProjectList")]
        [Validation(Required=false)]
        public List<ListEditingProjectsResponseBodyProjectList> ProjectList { get; set; }
        public class ListEditingProjectsResponseBodyProjectList : TeaModel {
            /// <summary>
            /// <para>The business configuration of the project. This parameter can be ignored for general editing projects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BusinessConfig")]
            [Validation(Required=false)]
            public string BusinessConfig { get; set; }

            /// <summary>
            /// <para>The business status of the project. This parameter can be ignored for general editing projects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The thumbnail URL of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.com/cover/xxx.jpg">https://xxx.com/cover/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The method for editing the online editing project. Valid values:</para>
            /// <para>\- OpenAPI</para>
            /// <para>\- AliyunConsole</para>
            /// <para>\- WebSDK</para>
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
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>The specified parameter \&quot;LiveStreamConfig\&quot; is not valid. specified parameter example is not valid.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The method for modifying the online editing project last time.</para>
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
            /// <para>The type of the editing project. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EditingProject: a regular editing project.</description></item>
            /// <item><description>LiveEditingProject: a live stream editing project.</description></item>
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
            /// <para>\- Draft</para>
            /// <para>\- Editing</para>
            /// <para>\- Producing</para>
            /// <para>\- Produced</para>
            /// <para>\- ProduceFailed</para>
            /// 
            /// <b>Example:</b>
            /// <para>Produced</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Timeline: a regular template.</description></item>
            /// <item><description>VETemplate: an advanced template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Timeline</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

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
        /// <para><em><b><b>ACB-44F2-5F2D-88D7-1283E70</b></b></em></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
