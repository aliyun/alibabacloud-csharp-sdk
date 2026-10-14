// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopRefererResponseBody : TeaModel {
        /// <summary>
        /// <para>The top referer data of the website.</para>
        /// </summary>
        [NameInMap("DomainTopReferer")]
        [Validation(Required=false)]
        public List<DescribeDomainTopRefererResponseBodyDomainTopReferer> DomainTopReferer { get; set; }
        public class DescribeDomainTopRefererResponseBodyDomainTopReferer : TeaModel {
            /// <summary>
            /// <para>The domain name of the website service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The number of request matches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>257031</para>
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            /// <summary>
            /// <para>The Base64-encoded value of the referer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aHR0cHM6Ly9zZXJ2aWNld2VjaGF0LmNvbS93eGY3ZDc5YWY0YzU4ZDH3NTEvNC9wYWdlLWZyYW1lLmh0bWw=</para>
            /// </summary>
            [NameInMap("Referer")]
            [Validation(Required=false)]
            public string Referer { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
