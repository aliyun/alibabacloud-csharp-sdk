// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class AssignCertificateCountRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f0167b4-ee84-XXX-49bc4d39fa68</para>
        /// </summary>
        [NameInMap("CaIdentifier")]
        [Validation(Required=false)]
        public string CaIdentifier { get; set; }

        /// <summary>
        /// <para>The total number of certificate records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("CertTotalCount")]
        [Validation(Required=false)]
        public int? CertTotalCount { get; set; }

        /// <summary>
        /// <para>The ID of the data source to which the certificate belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33285</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
