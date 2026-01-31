// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetInstanceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoReissueCount")]
        [Validation(Required=false)]
        public int? AutoReissueCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CertificateCount")]
        [Validation(Required=false)]
        public int? CertificateCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InactiveCount")]
        [Validation(Required=false)]
        public int? InactiveCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>09470F19-CEE8-5C63-BF2C-02B5E3F07A17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WillExpireCount")]
        [Validation(Required=false)]
        public int? WillExpireCount { get; set; }

    }

}
