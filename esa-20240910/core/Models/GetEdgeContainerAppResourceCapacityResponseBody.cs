// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppResourceCapacityResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried region.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<GetEdgeContainerAppResourceCapacityResponseBodyRegions> Regions { get; set; }
        public class GetEdgeContainerAppResourceCapacityResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>Supported ISPs are as follows. The parameter is left empty for regions outside the Chinese mainland. ISP:</para>
            /// <list type="bullet">
            /// <item><description>China Mobile: cmcc</description></item>
            /// <item><description>China Telecom: chinanet</description></item>
            /// <item><description>China Unicom: unicom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unicom</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>Chinese mainland:</para>
            /// <list type="bullet">
            /// <item><description>East China: huadong</description></item>
            /// <item><description>South China: huanan</description></item>
            /// <item><description>Central China: huazhong</description></item>
            /// <item><description>North China: huabei</description></item>
            /// <item><description>Northwest China: xibei</description></item>
            /// <item><description>Southwest China: xinan</description></item>
            /// <item><description>Northeast China: dongbei</description></item>
            /// </list>
            /// <para>Special Administrative Regions and Overseas:</para>
            /// <list type="bullet">
            /// <item><description>Taiwan, China: tw</description></item>
            /// <item><description>Macau, China: mo</description></item>
            /// <item><description>Hong Kong, China: hk</description></item>
            /// <item><description>Japan: jp</description></item>
            /// <item><description>United States: us</description></item>
            /// <item><description>Thailand: th</description></item>
            /// <item><description>Korea: kr</description></item>
            /// <item><description>Russia: ru</description></item>
            /// <item><description>Singapore: sg</description></item>
            /// <item><description>France: fr</description></item>
            /// <item><description>Spain: es</description></item>
            /// <item><description>Italy: it</description></item>
            /// <item><description>Sweden: se</description></item>
            /// <item><description>UAE: ae</description></item>
            /// <item><description>Indonesia: id</description></item>
            /// <item><description>Chile: cl</description></item>
            /// <item><description>Philippines: ph</description></item>
            /// <item><description>Malaysia: my</description></item>
            /// <item><description>Vietnam: vn</description></item>
            /// <item><description>Argentina: AR</description></item>
            /// <item><description>Australia: au</description></item>
            /// <item><description>Brazil: br</description></item>
            /// <item><description>Colombia: co</description></item>
            /// <item><description>Germany: de</description></item>
            /// <item><description>UK: GB</description></item>
            /// <item><description>Peru: pe</description></item>
            /// <item><description>Saudi Arabia: sa</description></item>
            /// <item><description>Netherlands: nl</description></item>
            /// <item><description>South Africa: za</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>huadong</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The number of container replicas that can be deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50423A7F-A83D-1E24-B80E-86DD25790759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
