// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainSecureVulListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of vulnerabilities returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The domain name-related vulnerabilities.</para>
        /// </summary>
        [NameInMap("VulList")]
        [Validation(Required=false)]
        public List<DescribeDomainSecureVulListResponseBodyVulList> VulList { get; set; }
        public class DescribeDomainSecureVulListResponseBodyVulList : TeaModel {
            /// <summary>
            /// <para>The alias of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CESA-2023:3555: python Security Update</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The number of the vulnerabilities that have the <b>high</b> priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639371446000</para>
            /// </summary>
            [NameInMap("GmtLast")]
            [Validation(Required=false)]
            public long? GmtLast { get; set; }

            /// <summary>
            /// <para>The number of handled vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("HandledCount")]
            [Validation(Required=false)]
            public int? HandledCount { get; set; }

            /// <summary>
            /// <para>The number of the vulnerabilities that have the <b>medium</b> priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oval:com.redhat.rhsa:def:20170574</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of the vulnerabilities that have the <b>low</b> priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// <para>The tag that is added to the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Restart required</description></item>
            /// <item><description>Remote utilization</description></item>
            /// <item><description>EXP exists</description></item>
            /// <item><description>Available</description></item>
            /// <item><description>Elevation of Privilege</description></item>
            /// <item><description>Code Execution</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Code Execution</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The type of the vulnerability. Default value: cve. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: Linux software vulnerability.</description></item>
            /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
            /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
            /// <item><description><b>app</b>: application vulnerability that is detected by network scanning.</description></item>
            /// <item><description><b>sca</b>: application vulnerability that is detected by using software component analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
