// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GenerateTraceDiagnoseResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64D28B53-5902-409B-94F6-FD46680144FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A diagnostic message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Origin IP x.x.x.x: Test URL returned HTTP 404 (non-2xx status).
        /// Origin IP x.x.x.x: DNS A record does not point to an ESA service IP.</para>
        /// </summary>
        [NameInMap("Tip")]
        [Validation(Required=false)]
        public string Tip { get; set; }

        /// <summary>
        /// <para>The generated diagnostic link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://cdn.dns-detect.alicdn.com/diagnose_v2?id=5d97ac9b&token=WFji65gy2mGNM11bD929%2BCMoyI6mbk2deRR9hOC6INH%2FoYbccQZQcvEn4wc%2FDPHlTshxRSAa5HokX%2BabItBpJ0FdnteROssomXqgIdjHpM46L%2BbaIeweZfsWG6QnbXT5n7O5APMyc%2Fe8d1o9PwwB429Ccks1FU1AfjNZfvBcLeo%3D">http://cdn.dns-detect.alicdn.com/diagnose_v2?id=5d97ac9b&amp;token=WFji65gy2mGNM11bD929%2BCMoyI6mbk2deRR9hOC6INH%2FoYbccQZQcvEn4wc%2FDPHlTshxRSAa5HokX%2BabItBpJ0FdnteROssomXqgIdjHpM46L%2BbaIeweZfsWG6QnbXT5n7O5APMyc%2Fe8d1o9PwwB429Ccks1FU1AfjNZfvBcLeo%3D</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
