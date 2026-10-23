// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListWorkflowTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The list of template summaries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListWorkflowTemplatesResponseBodyItems> Items { get; set; }
        public class ListWorkflowTemplatesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The current effective version number. An empty value indicates that only a draft exists and the template cannot be used for work items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("effectiveVersion")]
            [Validation(Required=false)]
            public string EffectiveVersion { get; set; }

            /// <summary>
            /// <para>The time when the template was last modified. The time is in the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The latest version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The status of the latest version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DRAFT: Draft. The version contains uncommitted edits.</description></item>
            /// <item><description>SUBMITTED: Submitted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFT</para>
            /// </summary>
            [NameInMap("latestVersionStatus")]
            [Validation(Required=false)]
            public string LatestVersionStatus { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of unique owners.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ownerCount")]
            [Validation(Required=false)]
            public long? OwnerCount { get; set; }

            /// <summary>
            /// <para>The number of steps configured with reviewers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("reviewStepCount")]
            [Validation(Required=false)]
            public long? ReviewStepCount { get; set; }

            /// <summary>
            /// <para>The number of steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("stepCount")]
            [Validation(Required=false)]
            public long? StepCount { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per page in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty string indicates that no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of visible entries that match the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
