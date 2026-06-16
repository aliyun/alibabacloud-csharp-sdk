// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class AssignCertificateCountRequest : TeaModel {
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
        /// <para>The ID of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33285</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
