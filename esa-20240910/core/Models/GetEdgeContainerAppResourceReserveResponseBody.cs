// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppResourceReserveResponseBody : TeaModel {
        /// <summary>
        /// <para>The reservation expiration time. This parameter uses UTC time. To convert from UTC+8, add 8 hours. For example, if the current UTC+8 time is 2006-01-02 06:04:05, enter &quot;2006-01-02T14:04:05Z&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02T15:04:05Z</para>
        /// </summary>
        [NameInMap("DurationTime")]
        [Validation(Required=false)]
        public string DurationTime { get; set; }

        /// <summary>
        /// <para>Indicates whether resource reservation is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Indicates whether the reservation is permanently enabled.</para>
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
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of reserved resources.</para>
        /// </summary>
        [NameInMap("ReserveSet")]
        [Validation(Required=false)]
        public List<GetEdgeContainerAppResourceReserveResponseBodyReserveSet> ReserveSet { get; set; }
        public class GetEdgeContainerAppResourceReserveResponseBodyReserveSet : TeaModel {
            /// <summary>
            /// <para>The following Internet service providers (ISPs) are supported. This parameter is not required for regions outside the Chinese mainland.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cmcc: China Mobile</description></item>
            /// <item><description>chinanet: China Telecom</description></item>
            /// <item><description>unicom: China Unicom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The Chinese mainland:</para>
            /// <list type="bullet">
            /// <item><description>East China: huadong</description></item>
            /// <item><description>South China: huanan</description></item>
            /// <item><description>Central China: huazhong</description></item>
            /// <item><description>North China: huabei</description></item>
            /// <item><description>Northwest China: xibei</description></item>
            /// <item><description>Southwest China: xinan</description></item>
            /// <item><description>Northeast China: dongbei</description></item>
            /// </list>
            /// <para>Special administrative regions and outside China:</para>
            /// <list type="bullet">
            /// <item><description>Taiwan (China): tw</description></item>
            /// <item><description>Macao (China): mo</description></item>
            /// <item><description>Hong Kong (China): hk</description></item>
            /// <item><description>Japan: jp</description></item>
            /// <item><description>United States: us</description></item>
            /// <item><description>Thailand: th</description></item>
            /// <item><description>South Korea: kr</description></item>
            /// <item><description>Russia: ru</description></item>
            /// <item><description>Singapore: sg</description></item>
            /// <item><description>France: fr</description></item>
            /// <item><description>Spain: es</description></item>
            /// <item><description>Italy: it</description></item>
            /// <item><description>Sweden: se</description></item>
            /// <item><description>United Arab Emirates: ae</description></item>
            /// <item><description>Indonesia: id</description></item>
            /// <item><description>Chile: cl</description></item>
            /// <item><description>Philippines: ph</description></item>
            /// <item><description>Malaysia: my</description></item>
            /// <item><description>Vietnam: vn</description></item>
            /// <item><description>Argentina: ar</description></item>
            /// <item><description>Australia: au</description></item>
            /// <item><description>Brazil: br</description></item>
            /// <item><description>Colombia: co</description></item>
            /// <item><description>Germany: de</description></item>
            /// <item><description>United Kingdom: gb</description></item>
            /// <item><description>Peru: pe</description></item>
            /// <item><description>Saudi Arabia: sa</description></item>
            /// <item><description>Netherlands: nl</description></item>
            /// <item><description>South Africa: za.</description></item>
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
