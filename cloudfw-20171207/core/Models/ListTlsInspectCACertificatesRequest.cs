// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListTlsInspectCACertificatesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>C3E91391-16CD-1BFC-A133-******D429</para>
        /// </summary>
        [NameInMap("CaCertId")]
        [Validation(Required=false)]
        public string CaCertId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
