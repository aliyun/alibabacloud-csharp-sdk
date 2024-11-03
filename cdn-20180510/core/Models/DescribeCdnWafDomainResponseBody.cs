// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnWafDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the accelerated domain name.</para>
        /// </summary>
        [NameInMap("OutPutDomains")]
        [Validation(Required=false)]
        public List<DescribeCdnWafDomainResponseBodyOutPutDomains> OutPutDomains { get; set; }
        public class DescribeCdnWafDomainResponseBodyOutPutDomains : TeaModel {
            /// <summary>
            /// <para>The status of the access control list (ACL) feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// <para>The status of protection against HTTP flood attacks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CcStatus")]
            [Validation(Required=false)]
            public string CcStatus { get; set; }

            /// <summary>
            /// <para>The accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The WAF status of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The domain name is added to WAF or valid.</description></item>
            /// <item><description><b>10</b>: The domain name is being added to WAF.</description></item>
            /// <item><description><b>11</b>: The domain name failed to be added to WAF.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The status of WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WafStatus")]
            [Validation(Required=false)]
            public string WafStatus { get; set; }

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
        /// <para>The number of accelerated domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
