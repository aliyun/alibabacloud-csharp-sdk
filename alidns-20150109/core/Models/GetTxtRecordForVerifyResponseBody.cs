// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class GetTxtRecordForVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// <remarks>
        /// <para>This parameter is not returned if no value is specified for the DomainName parameter in the request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The top-level domain (TLD).</para>
        /// 
        /// <b>Example:</b>
        /// <para>com</para>
        /// </summary>
        [NameInMap("ParentDomainName")]
        [Validation(Required=false)]
        public string ParentDomainName { get; set; }

        /// <summary>
        /// <para>The host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun******</para>
        /// </summary>
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9CC0D642-49D4-48DE-A1A5-9F218652E4A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The record value.</para>
        /// <remarks>
        /// <para>The value is valid for three days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c99419e6997f41daaa3e*****</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
