// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class DescribeAgreementStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10aa40008e081ad7b1fb50bffc3a70b1</para>
        /// </summary>
        [NameInMap("AgreementCode")]
        [Validation(Required=false)]
        public string AgreementCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6254E13A-A79F-5786-9C75-7590727342C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1219541161213057</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
