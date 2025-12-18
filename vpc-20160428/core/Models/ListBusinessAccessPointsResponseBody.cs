// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListBusinessAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of access points.</para>
        /// </summary>
        [NameInMap("BusinessAccessPoints")]
        [Validation(Required=false)]
        public List<ListBusinessAccessPointsResponseBodyBusinessAccessPoints> BusinessAccessPoints { get; set; }
        public class ListBusinessAccessPointsResponseBodyBusinessAccessPoints : TeaModel {
            /// <summary>
            /// <para>The ID of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-cn-hangzhou-xs-B</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The name of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou-xs-B</para>
            /// </summary>
            [NameInMap("AccessPointName")]
            [Validation(Required=false)]
            public string AccessPointName { get; set; }

            /// <summary>
            /// <para>The ID of the cloud box.</para>
            /// <remarks>
            /// <para> You can query this parameter if the Express Connect circuits and access points are of the cloud box type.</para>
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

            [NameInMap("OpticalModuleModels")]
            [Validation(Required=false)]
            public List<ListBusinessAccessPointsResponseBodyBusinessAccessPointsOpticalModuleModels> OpticalModuleModels { get; set; }
            public class ListBusinessAccessPointsResponseBodyBusinessAccessPointsOpticalModuleModels : TeaModel {
                [NameInMap("OpticalModuleModel")]
                [Validation(Required=false)]
                public string OpticalModuleModel { get; set; }

                [NameInMap("PortType")]
                [Validation(Required=false)]
                public string PortType { get; set; }

            }

            /// <summary>
            /// <para>The connectivity provider of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CT</b>: China Telecom.</description></item>
            /// <item><description><b>CU</b>: China Unicom.</description></item>
            /// <item><description><b>CM</b>: China Mobile.</description></item>
            /// <item><description><b>CO</b>: other connectivity providers in the Chinese mainland.</description></item>
            /// <item><description><b>Equinix</b>: Equinix.</description></item>
            /// <item><description><b>Other</b>: other connectivity providers outside the Chinese mainland.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CT</para>
            /// </summary>
            [NameInMap("SupportLineOperator")]
            [Validation(Required=false)]
            public string SupportLineOperator { get; set; }

            /// <summary>
            /// <para>The port type supported by the access point. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100Base-T</b>: 100 Mbit/s copper Ethernet port</description></item>
            /// <item><description><b>1000Base-T</b>: 1,000 Mbit/s copper Ethernet port</description></item>
            /// <item><description><b>1000Base-LX</b>: 1,000 Mbit/s single-mode optical port (10 km)</description></item>
            /// <item><description><b>10GBase-T</b>: 10,000 Mbit/s copper Ethernet port</description></item>
            /// <item><description><b>10GBase-LR</b>: 10,000 Mbit/s single-mode optical port (10 km)</description></item>
            /// <item><description><b>40GBase-LR</b>: 40,000 Mbit/s single-mode optical port</description></item>
            /// <item><description><b>100GBase-LR</b>: 100,000 Mbit/s single-mode optical port</description></item>
            /// </list>
            /// <remarks>
            /// <para> To use ports 40GBase-LR and 100GBase-LR, you must first contact your account manager.</para>
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
