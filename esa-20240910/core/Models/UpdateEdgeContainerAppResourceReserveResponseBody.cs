// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateEdgeContainerAppResourceReserveResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time of the reservation. The input time is UTC. It takes +8 hours to enter Beijing time. For example, if the current time is 2006-01-02 06:04:05, you need to enter &quot;2006-01-02T14:04:05Z&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02T15:04:05Z</para>
        /// </summary>
        [NameInMap("DurationTime")]
        [Validation(Required=false)]
        public string DurationTime { get; set; }

        /// <summary>
        /// <para>Whether to enable resource reservation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Enable Permanent Incremental Backup</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Forever")]
        [Validation(Required=false)]
        public bool? Forever { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AB799CF-562A-5CAF-A99E-4354053D814F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Reserved resource list.</para>
        /// </summary>
        [NameInMap("ReserveSet")]
        [Validation(Required=false)]
        public List<UpdateEdgeContainerAppResourceReserveResponseBodyReserveSet> ReserveSet { get; set; }
        public class UpdateEdgeContainerAppResourceReserveResponseBodyReserveSet : TeaModel {
            /// <summary>
            /// <para>The ISP. The following types are supported. You do not need to enter the ISP in regions outside the Chinese mainland:</para>
            /// <list type="bullet">
            /// <item><description>China Mobile: cmcc</description></item>
            /// <item><description>China Telecom: chinanet</description></item>
            /// <item><description>China Unicom: unicom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>Information about the region. The Chinese mainland supports the input of regions and special administrative regions, and the regions outside the Chinese mainland support the input of countries. The following is the corresponding parameter mapping:</para>
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
            /// <para>Special Administrative Regions and overseas:</para>
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
            /// <para>huazhong</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The number of container replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

        }

    }

}
