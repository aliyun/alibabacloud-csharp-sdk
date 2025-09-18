// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListOpsNoticesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OpsNotices")]
        [Validation(Required=false)]
        public List<ListOpsNoticesResponseBodyOpsNotices> OpsNotices { get; set; }
        public class ListOpsNoticesResponseBodyOpsNotices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;cveId&quot;:&quot;CVE-2021-4034&quot;}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>notice-1749693290</para>
            /// </summary>
            [NameInMap("NoticeId")]
            [Validation(Required=false)]
            public string NoticeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>service-e10349089de34exxxxxx</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServiceVersions")]
            [Validation(Required=false)]
            public List<string> ServiceVersions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>You need to upgrade service instance</para>
            /// </summary>
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public string Solutions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-10-12T02:03:37Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Vulnerability</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
