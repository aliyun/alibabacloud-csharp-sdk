// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetVulItemPageResponseBody : TeaModel {
        /// <summary>
        /// <para>API response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetVulItemPageResponseBodyData> Data { get; set; }
        public class GetVulItemPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Vulnerability alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RHSA-2024:4620: libndp 安全更新</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>Number of high-priority vulnerabilities to be fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74</para>
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1940494487193744</para>
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>Prefix for the CVE remediation advice URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://avd.aliyun.com/detail/">https://avd.aliyun.com/detail/</a></para>
            /// </summary>
            [NameInMap("CveUrlPrefix")]
            [Validation(Required=false)]
            public string CveUrlPrefix { get; set; }

            /// <summary>
            /// <para>Processing status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>y</para>
            /// </summary>
            [NameInMap("Dealed")]
            [Validation(Required=false)]
            public string Dealed { get; set; }

            /// <summary>
            /// <para>Timestamp of the last discovery of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-23 14:47:34</para>
            /// </summary>
            [NameInMap("FindTime")]
            [Validation(Required=false)]
            public string FindTime { get; set; }

            /// <summary>
            /// <para>Number of processed vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("HandledCount")]
            [Validation(Required=false)]
            public int? HandledCount { get; set; }

            /// <summary>
            /// <para>Primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>353845</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Number of medium-priority vulnerabilities to be fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// <para>Risk level</para>
            /// 
            /// <b>Example:</b>
            /// <para>later</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Vulnerability name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oval:com.redhat.rhsa:def:20205002</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Number of low-priority vulnerabilities to be fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// <para>CVE number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2019-20907</para>
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// <para>Number of related CVE numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("RelatedCveCount")]
            [Validation(Required=false)]
            public int? RelatedCveCount { get; set; }

            /// <summary>
            /// <para>Vulnerability type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sca</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>Tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elevation of Privilege</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>Total number of fixed vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalFixCount")]
            [Validation(Required=false)]
            public long? TotalFixCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Prompt message for the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetVulItemPageResponseBodyPageInfo PageInfo { get; set; }
        public class GetVulItemPageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number for pagination queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Number of items to display per page in the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records in the query result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>163</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02F8BBF3-2D61-5982-8911-EEB387BE3AF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful.
        /// true: Call succeeded. false: Call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
