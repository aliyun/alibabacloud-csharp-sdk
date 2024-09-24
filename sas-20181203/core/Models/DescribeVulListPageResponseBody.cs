// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeVulListPageResponseBodyData> Data { get; set; }
        public class DescribeVulListPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The common vulnerabilities and exposures (CVE) ID of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2022-42836</para>
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <para>The extended field for Server Guard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;relatedType\&quot;:[{\&quot;type\&quot;:\&quot;sys\&quot;}]}</para>
            /// </summary>
            [NameInMap("ExtAegis")]
            [Validation(Required=false)]
            public string ExtAegis { get; set; }

            /// <summary>
            /// <para>The primary key ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40586</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the vulnerability was detected based on version comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The vulnerability was detected based on version comparison.</description></item>
            /// <item><description>0: The vulnerability was not detected based on version comparison.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsAegis")]
            [Validation(Required=false)]
            public int? IsAegis { get; set; }

            /// <summary>
            /// <para>Indicates whether the vulnerability was detected based on proof of concept (POC) verification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The vulnerability was detected based on POC verification.</description></item>
            /// <item><description>0: The vulnerability was not detected based on POC verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsSas")]
            [Validation(Required=false)]
            public int? IsSas { get; set; }

            /// <summary>
            /// <para>The ID of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVD-2018-8218</para>
            /// </summary>
            [NameInMap("OtherId")]
            [Validation(Required=false)]
            public string OtherId { get; set; }

            /// <summary>
            /// <para>The time when the vulnerability was disclosed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-13T08:00Z</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows RCE vulnerability</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4347E985-6E64-467B-96EC-30D4EA9E32FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
