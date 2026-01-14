// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListIspTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The line types of EIPs in the acceleration region.</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (Multi-ISP) lines</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro lines</description></item>
        /// </list>
        /// <para>If you have the permissions to use single-ISP bandwidth, one of the following values may be returned:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom (single ISP)</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom (single ISP)</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile (single ISP)</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom_L2 (single ISP)</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom_L2 (single ISP)</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile_L2 (single ISP)</description></item>
        /// </list>
        /// <remarks>
        /// <para>Different acceleration regions support different single-ISP BGP lines.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("IspTypeList")]
        [Validation(Required=false)]
        public List<string> IspTypeList { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F591955F-5CB5-4CCE-A75D-17CF2085CE22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
