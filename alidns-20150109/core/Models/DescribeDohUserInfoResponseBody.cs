// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of accessed domains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public int? DomainCount { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud public DNS user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("PdnsId")]
        [Validation(Required=false)]
        public long? PdnsId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0F32959D-417B-4D66-8463-68606605E3E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of accessed subdomains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("SubDomainCount")]
        [Validation(Required=false)]
        public int? SubDomainCount { get; set; }

    }

}
