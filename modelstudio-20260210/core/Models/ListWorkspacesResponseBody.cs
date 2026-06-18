// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve more results. You do not need to specify this parameter for the first request. For subsequent requests, use the token returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TbB1IsZUSR4iE</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD3695-77E0-5784-B8A6-C213A01781FE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>149</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of business workspaces.</para>
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class ListWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// <para>API Host。</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm-34o9ts1dai60z5sf.cn-beijing.maas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("apiHost")]
            [Validation(Required=false)]
            public string ApiHost { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742785623772</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The service deployment scope. For more information, see <a href="https://www.alibabacloud.com/help/zh/model-studio/regions/">documentation</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("serviceSite")]
            [Validation(Required=false)]
            public string ServiceSite { get; set; }

            /// <summary>
            /// <para>The business workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-0759e7b7ea7f585b</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The business workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("workspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

    }

}
