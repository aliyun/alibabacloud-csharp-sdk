// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetMainDomainNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The level of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DomainLevel")]
        [Validation(Required=false)]
        public int? DomainLevel { get; set; }

        /// <summary>
        /// <para>The root domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("MainDomainName")]
        [Validation(Required=false)]
        public string MainDomainName { get; set; }

        /// <summary>
        /// <para>The host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub</para>
        /// </summary>
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9732E117-8A37-49FD-A36F-ABBB87556CA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
