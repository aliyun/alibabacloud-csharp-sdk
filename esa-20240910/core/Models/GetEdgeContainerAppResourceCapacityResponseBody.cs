// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppResourceCapacityResponseBody : TeaModel {
        /// <summary>
        /// <para>The available regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<GetEdgeContainerAppResourceCapacityResponseBodyRegions> Regions { get; set; }
        public class GetEdgeContainerAppResourceCapacityResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The carrier. This parameter is returned only for regions in the Chinese mainland. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cmcc: China Mobile</para>
            /// </description></item>
            /// <item><description><para>chinanet: China Telecom</para>
            /// </description></item>
            /// <item><description><para>unicom: China Unicom</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unicom</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The Chinese mainland:</para>
            /// <list type="bullet">
            /// <item><description><para>huadong: East China</para>
            /// </description></item>
            /// <item><description><para>huanan: South China</para>
            /// </description></item>
            /// <item><description><para>huazhong: Central China</para>
            /// </description></item>
            /// <item><description><para>huabei: North China</para>
            /// </description></item>
            /// <item><description><para>xibei: Northwest China</para>
            /// </description></item>
            /// <item><description><para>xinan: Southwest China</para>
            /// </description></item>
            /// <item><description><para>dongbei: Northeast China</para>
            /// </description></item>
            /// </list>
            /// <para>Special administrative regions and regions outside the Chinese mainland:</para>
            /// <list type="bullet">
            /// <item><description><para>tw: Taiwan (China)</para>
            /// </description></item>
            /// <item><description><para>mo: Macao (China)</para>
            /// </description></item>
            /// <item><description><para>hk: Hong Kong (China)</para>
            /// </description></item>
            /// <item><description><para>jp: Japan</para>
            /// </description></item>
            /// <item><description><para>us: US</para>
            /// </description></item>
            /// <item><description><para>th: Thailand</para>
            /// </description></item>
            /// <item><description><para>kr: South Korea</para>
            /// </description></item>
            /// <item><description><para>ru: Russia</para>
            /// </description></item>
            /// <item><description><para>sg: Singapore</para>
            /// </description></item>
            /// <item><description><para>fr: France</para>
            /// </description></item>
            /// <item><description><para>es: Spain</para>
            /// </description></item>
            /// <item><description><para>it: Italy</para>
            /// </description></item>
            /// <item><description><para>se: Sweden</para>
            /// </description></item>
            /// <item><description><para>ae: UAE</para>
            /// </description></item>
            /// <item><description><para>id: Indonesia</para>
            /// </description></item>
            /// <item><description><para>cl: Chile</para>
            /// </description></item>
            /// <item><description><para>ph: Philippines</para>
            /// </description></item>
            /// <item><description><para>my: Malaysia</para>
            /// </description></item>
            /// <item><description><para>vn: Vietnam</para>
            /// </description></item>
            /// <item><description><para>ar: Argentina</para>
            /// </description></item>
            /// <item><description><para>au: Australia</para>
            /// </description></item>
            /// <item><description><para>br: Brazil</para>
            /// </description></item>
            /// <item><description><para>co: Colombia</para>
            /// </description></item>
            /// <item><description><para>de: Germany</para>
            /// </description></item>
            /// <item><description><para>gb: UK</para>
            /// </description></item>
            /// <item><description><para>pe: Peru</para>
            /// </description></item>
            /// <item><description><para>sa: Saudi Arabia</para>
            /// </description></item>
            /// <item><description><para>nl: Netherlands</para>
            /// </description></item>
            /// <item><description><para>za: South Africa</para>
            /// </description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50423A7F-A83D-1E24-B80E-86DD25790759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
