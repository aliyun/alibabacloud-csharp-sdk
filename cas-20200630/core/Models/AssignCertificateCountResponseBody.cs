// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class AssignCertificateCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of assigned certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CertCount")]
        [Validation(Required=false)]
        public int? CertCount { get; set; }

        /// <summary>
        /// <para>The number of free certificates for the current year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CurrentYearFreeCertCount")]
        [Validation(Required=false)]
        public int? CurrentYearFreeCertCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E77C4794-F24F-58CB-9929-F0F0C0EDE7B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
