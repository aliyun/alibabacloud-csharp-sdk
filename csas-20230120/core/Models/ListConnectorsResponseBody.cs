// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListConnectorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of connectors.</para>
        /// </summary>
        [NameInMap("Connectors")]
        [Validation(Required=false)]
        public List<ListConnectorsResponseBodyConnectors> Connectors { get; set; }
        public class ListConnectorsResponseBodyConnectors : TeaModel {
            /// <summary>
            /// <para>Specifies whether global acceleration is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("AccelerateStatus")]
            [Validation(Required=false)]
            public string AccelerateStatus { get; set; }

            /// <summary>
            /// <para>The internal access applications associated with the connector.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListConnectorsResponseBodyConnectorsApplications> Applications { get; set; }
            public class ListConnectorsResponseBodyConnectorsApplications : TeaModel {
                /// <summary>
                /// <para>The ID of the internal access application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-application-e12860ef6c48****</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <para>The name of the internal access application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application_name</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

            }

            /// <summary>
            /// <para>The IP address of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("ClusterIP")]
            [Validation(Required=false)]
            public string ClusterIP { get; set; }

            /// <summary>
            /// <para>The port of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("ClusterPort")]
            [Validation(Required=false)]
            public string ClusterPort { get; set; }

            /// <summary>
            /// <para>The deployed connector clients.</para>
            /// </summary>
            [NameInMap("ConnectorClients")]
            [Validation(Required=false)]
            public List<ListConnectorsResponseBodyConnectorsConnectorClients> ConnectorClients { get; set; }
            public class ListConnectorsResponseBodyConnectorsConnectorClients : TeaModel {
                /// <summary>
                /// <para>The connection status between the connector client and the connector server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Disconnected</para>
                /// </summary>
                [NameInMap("ConnectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                /// <summary>
                /// <para>The unique device identifier of the connector client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C50A2386-F851-4F11-920B-DF7148DA0C22</para>
                /// </summary>
                [NameInMap("DevTag")]
                [Validation(Required=false)]
                public string DevTag { get; set; }

                /// <summary>
                /// <para>The hostname of the connector client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>connector_client</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The public IP address of the connector client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.1</para>
                /// </summary>
                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

            }

            /// <summary>
            /// <para>The connector ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-94db94e06b98****</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <para>The time when the connector was created. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-27 18:10:25</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The connection status of the connector. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Online</b>: Online.</description></item>
            /// <item><description><b>Offline</b>: Offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The connector instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

            /// <summary>
            /// <para>The upgrade time of the connector.</para>
            /// </summary>
            [NameInMap("UpgradeTime")]
            [Validation(Required=false)]
            public ListConnectorsResponseBodyConnectorsUpgradeTime UpgradeTime { get; set; }
            public class ListConnectorsResponseBodyConnectorsUpgradeTime : TeaModel {
                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23:00</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20:00</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            [NameInMap("VipCidr")]
            [Validation(Required=false)]
            public string VipCidr { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of connectors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
