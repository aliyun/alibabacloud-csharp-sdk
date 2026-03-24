// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeMajorProtectionBlackIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of IP addresses in the blacklist.</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<DescribeMajorProtectionBlackIpsResponseBodyIpList> IpList { get; set; }
        public class DescribeMajorProtectionBlackIpsResponseBodyIpList : TeaModel {
            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test0003asdffas</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The timestamp after which the IP address blacklist becomes invalid. Unit: seconds.</para>
            /// <remarks>
            /// <para>If the value is <b>0</b>, the IP address blacklist is permanently valid.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1662603328</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// <para>The time when the IP address in the blacklist was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665456202000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The ID of the IP address blacklist rule for critical event protection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8508970</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The ID of the critical event protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9684</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41631674-EEB0-5B02-BEB4-40A758E9B841</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of IP addresses in the blacklist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
