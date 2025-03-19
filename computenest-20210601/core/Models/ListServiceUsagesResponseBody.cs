// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceUsagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAYChudnQUoBH+mGWFpb6oP0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18AD0960-A9FE-1AC8-ADF8-22131Fxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service applications.</para>
        /// </summary>
        [NameInMap("ServiceUsages")]
        [Validation(Required=false)]
        public List<ListServiceUsagesResponseBodyServiceUsages> ServiceUsages { get; set; }
        public class ListServiceUsagesResponseBodyServiceUsages : TeaModel {
            /// <summary>
            /// <para>The review comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approved</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The time when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-25T02:02:02Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-c9f36ec6d19b4exxxxxx</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LobelChat</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The state of the service application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Submitted: The application is submitted for review.</description></item>
            /// <item><description>Approved: The application is approved.</description></item>
            /// <item><description>Rejected: The application is rejected.</description></item>
            /// <item><description>Canceled: The application is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Submitted</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestSupplier</para>
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// <para>The time when the application was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-25T02:02:02Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127383705958xxxx</para>
            /// </summary>
            [NameInMap("UserAliUid")]
            [Validation(Required=false)]
            public long? UserAliUid { get; set; }

            /// <summary>
            /// <para>The information about the applicants.</para>
            /// </summary>
            [NameInMap("UserInformation")]
            [Validation(Required=false)]
            public Dictionary<string, string> UserInformation { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
