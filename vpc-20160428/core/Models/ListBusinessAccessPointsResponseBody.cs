// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListBusinessAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of all access point information for Express Connect circuits.</para>
        /// </summary>
        [NameInMap("BusinessAccessPoints")]
        [Validation(Required=false)]
        public List<ListBusinessAccessPointsResponseBodyBusinessAccessPoints> BusinessAccessPoints { get; set; }
        public class ListBusinessAccessPointsResponseBodyBusinessAccessPoints : TeaModel {
            /// <summary>
            /// <para>The ID of the Express Connect circuit access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-cn-hangzhou-xs-B</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The name of the Express Connect circuit access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州-萧山-B</para>
            /// </summary>
            [NameInMap("AccessPointName")]
            [Validation(Required=false)]
            public string AccessPointName { get; set; }

            /// <summary>
            /// <para>The CloudBox instance ID.</para>
            /// <remarks>
            /// <para>This parameter is available only when the queried Express Connect circuit and access point are CloudBox Express Connect circuits and CloudBox access points.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cb-****</para>
            /// </summary>
            [NameInMap("CloudBoxInstanceIds")]
            [Validation(Required=false)]
            public string CloudBoxInstanceIds { get; set; }

            /// <summary>
            /// <para>The latitude of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.198416</para>
            /// </summary>
            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public double? Latitude { get; set; }

            /// <summary>
            /// <para>The longitude of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.247514</para>
            /// </summary>
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public double? Longitude { get; set; }

            /// <summary>
            /// <para>The collection of optical module models supported by the current access point.</para>
            /// </summary>
            [NameInMap("OpticalModuleModels")]
            [Validation(Required=false)]
            public List<ListBusinessAccessPointsResponseBodyBusinessAccessPointsOpticalModuleModels> OpticalModuleModels { get; set; }
            public class ListBusinessAccessPointsResponseBodyBusinessAccessPointsOpticalModuleModels : TeaModel {
                /// <summary>
                /// <para>The optical module model supported by the Express Connect circuit access point. Valid values:
                /// 1000Base-LX : 
                /// SFP-GE-LR-SM1310,10KM
                /// SFP-GE-ER-SM1310,40KM
                /// SFP-GE-ZR-SM1550,80KM 
                /// 10GBase-LR : 
                /// SFP-10G-LR-SM1310,10KM
                /// SFP-10G-ER-SM1550,40KM 
                /// SFP-10G-ZR-SM1550,80KM<br>40GBase-LR : 
                /// QSFP-40G-LR4-WDM1300,10KM
                /// QSFP-40G-ER4-WDM1300,40KM
                /// QSFP-40G-ZR4-WDM1300,80KM
                /// 100GBase-LR : 
                /// QSFP28-100G-LR4-WDM1300,10KM
                /// QSFP28-100G-ER4-WDM1300,40KM
                /// QSFP28-100G-ZR4-WDM1300,80KM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SFP-GE-LR-SM1310,10KM</para>
                /// </summary>
                [NameInMap("OpticalModuleModel")]
                [Validation(Required=false)]
                public string OpticalModuleModel { get; set; }

                /// <summary>
                /// <para>The port type supported by the optical module at the Express Connect circuit access point. Valid values:
                /// ● 1000Base-LX: GE single-mode optical port.
                /// ● 10GBase-LR: 10 GE single-mode optical port.
                /// ● 40GBase-LR: 40 GE single-mode optical port.
                /// ● 100GBase-LR: 100 GE single-mode optical port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000Base-LX</para>
                /// </summary>
                [NameInMap("PortType")]
                [Validation(Required=false)]
                public string PortType { get; set; }

            }

            /// <summary>
            /// <para>The telecommunications service providers that support physical line access. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CT</b>: China Telecom.</description></item>
            /// <item><description><b>CU</b>: China Unicom.</description></item>
            /// <item><description><b>CM</b>: China Mobile.</description></item>
            /// <item><description><b>CO</b>: Other Chinese providers.</description></item>
            /// <item><description><b>Equinix</b>: Equinix.</description></item>
            /// <item><description><b>Other</b>: Other providers outside the Chinese mainland.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CT</para>
            /// </summary>
            [NameInMap("SupportLineOperator")]
            [Validation(Required=false)]
            public string SupportLineOperator { get; set; }

            /// <summary>
            /// <para>The port types available for purchase at the Express Connect circuit access point. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100Base-T</b>: 100M Ethernet port.</description></item>
            /// <item><description><b>1000Base-T</b>: 1 GE electrical port.</description></item>
            /// <item><description><b>1000Base-LX</b>: GE single-mode optical port (10 km).</description></item>
            /// <item><description><b>10GBase-T</b>: 10 GE electrical port.</description></item>
            /// <item><description><b>10GBase-LR</b>: 10 GE single-mode optical port (10 km).</description></item>
            /// <item><description><b>40GBase-LR</b>: 40 GE single-mode optical port.</description></item>
            /// <item><description><b>100GBase-LR</b>: 100 GE single-mode optical port.</description></item>
            /// </list>
            /// <remarks>
            /// <para> The creation of 40GBase-LR and 100GBase-LR ports depends on the actual backend port availability. Contact your account manager for details.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000Base-T</para>
            /// </summary>
            [NameInMap("SupportPortTypes")]
            [Validation(Required=false)]
            public string SupportPortTypes { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>611CB80C-B6A9-43DB-9E38-0B0AC3D9B58F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
