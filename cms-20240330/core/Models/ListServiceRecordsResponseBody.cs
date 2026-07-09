// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListServiceRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2-ba4d-4b9f-aa24-dcb067a30f1c</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of ticket operation records.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ListServiceRecordsResponseBodyRecords> Records { get; set; }
        public class ListServiceRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The entry content in JSON string format. The format varies depending on the recordType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;project&quot;: &quot;proj-xtrace-16c988dcfe21fcb73c5e6f234927d998-cn-hangzhou&quot;,
            ///   &quot;storeName&quot;: &quot;app-biz-log&quot;,
            ///   &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
            ///   &quot;bindType&quot;: &quot;logstore&quot;,
            ///   &quot;traceIdRelateField&quot;: &quot;&quot;
            /// }</para>
            /// </summary>
            [NameInMap("recordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// <para>The type of the linked entry. Currently supported:
            /// logCorrelation, which indicates application log association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logCorrelation</para>
            /// </summary>
            [NameInMap("recordType")]
            [Validation(Required=false)]
            public string RecordType { get; set; }

            /// <summary>
            /// <para>The unique identifier of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gaddp9ap8q@f8ca37734da3eda787dbb</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace-test</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-XXXX-XXXX-XXXX-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
