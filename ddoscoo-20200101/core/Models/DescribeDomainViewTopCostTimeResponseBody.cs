// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewTopCostTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The URLs which require the longest time to respond to requests.</para>
        /// </summary>
        [NameInMap("UrlList")]
        [Validation(Required=false)]
        public List<DescribeDomainViewTopCostTimeResponseBodyUrlList> UrlList { get; set; }
        public class DescribeDomainViewTopCostTimeResponseBodyUrlList : TeaModel {
            /// <summary>
            /// <para>The response duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public float? CostTime { get; set; }

            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The URL that is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lw==</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
