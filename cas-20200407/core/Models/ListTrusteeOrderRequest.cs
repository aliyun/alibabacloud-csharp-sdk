// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListTrusteeOrderRequest : TeaModel {
        /// <summary>
        /// <para>The certificate ID. You must specify either CertificateId or OrderId. Both cannot be empty at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23787679</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public long? CertificateId { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. If NextToken is empty, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The order ID. You must specify either CertificateId or OrderId. Both cannot be empty at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14933279</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

    }

}
