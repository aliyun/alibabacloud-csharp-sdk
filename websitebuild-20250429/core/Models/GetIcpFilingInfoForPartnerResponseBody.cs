// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetIcpFilingInfoForPartnerResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIcpFilingInfoForPartnerResponseBodyData Data { get; set; }
        public class GetIcpFilingInfoForPartnerResponseBodyData : TeaModel {
            [NameInMap("IcpNumber")]
            [Validation(Required=false)]
            public string IcpNumber { get; set; }

            [NameInMap("Recorded")]
            [Validation(Required=false)]
            public bool? Recorded { get; set; }

            [NameInMap("SiteRecordNumber")]
            [Validation(Required=false)]
            public string SiteRecordNumber { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
