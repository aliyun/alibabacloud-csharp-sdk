// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// </summary>
        [NameInMap("OutPutDomains")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafDomainResponseBodyOutPutDomains> OutPutDomains { get; set; }
        public class DescribeDcdnWafDomainResponseBodyOutPutDomains : TeaModel {
            /// <summary>
            /// <para>The status of the ACL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disabled</description></item>
            /// <item><description>1: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public int? AclStatus { get; set; }

            /// <summary>
            /// <para>The status of protection against HTTP flood attacks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disabled</description></item>
            /// <item><description>1: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CcStatus")]
            [Validation(Required=false)]
            public int? CcStatus { get; set; }

            /// <summary>
            /// <para>The domain name that has WAF enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The status of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The domain name is added to WAF, or the domain name is valid.</description></item>
            /// <item><description>10: The domain name is being added to WAF.</description></item>
            /// <item><description>11: The domain name failed to be added to WAF.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The status of WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disabled</description></item>
            /// <item><description>1: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WafStatus")]
            [Validation(Required=false)]
            public int? WafStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-802B-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of accelerated domain names returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
