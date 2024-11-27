// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetVulItemPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetVulItemPageResponseBodyData> Data { get; set; }
        public class GetVulItemPageResponseBodyData : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>74</para>
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1940494487193744</para>
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://avd.aliyun.com/detail/">https://avd.aliyun.com/detail/</a></para>
            /// </summary>
            [NameInMap("CveUrlPrefix")]
            [Validation(Required=false)]
            public string CveUrlPrefix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>y</para>
            /// </summary>
            [NameInMap("Dealed")]
            [Validation(Required=false)]
            public string Dealed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-23 14:47:34</para>
            /// </summary>
            [NameInMap("FindTime")]
            [Validation(Required=false)]
            public string FindTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("HandledCount")]
            [Validation(Required=false)]
            public int? HandledCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>353845</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>later</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oval:com.redhat.rhsa:def:20205002</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CVE-2019-20907</para>
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("RelatedCveCount")]
            [Validation(Required=false)]
            public int? RelatedCveCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sca</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Elevation of Privilege</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalFixCount")]
            [Validation(Required=false)]
            public long? TotalFixCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetVulItemPageResponseBodyPageInfo PageInfo { get; set; }
        public class GetVulItemPageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>163</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02F8BBF3-2D61-5982-8911-EEB387BE3AF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
