// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListIspTypesResponseBody : TeaModel {
        /// <summary>
        /// The line types of EIPs in the acceleration region.
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) lines
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines
        /// 
        /// If you have the permissions to use single-ISP bandwidth, one of the following values may be returned:
        /// 
        /// *   **ChinaTelecom**: China Telecom (single ISP)
        /// *   **ChinaUnicom**: China Unicom (single ISP)
        /// *   **ChinaMobile**: China Mobile (single ISP)
        /// *   **ChinaTelecom_L2**: China Telecom_L2 (single ISP)
        /// *   **ChinaUnicom_L2**: China Unicom_L2 (single ISP)
        /// *   **ChinaMobile_L2**: China Mobile_L2 (single ISP)
        /// 
        /// > Different acceleration regions support different single-ISP BGP lines.
        /// </summary>
        [NameInMap("IspTypeList")]
        [Validation(Required=false)]
        public List<string> IspTypeList { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
