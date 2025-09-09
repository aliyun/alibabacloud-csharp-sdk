// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListConnectorsResponseBody : TeaModel {
        [NameInMap("Connectors")]
        [Validation(Required=false)]
        public List<ListConnectorsResponseBodyConnectors> Connectors { get; set; }
        public class ListConnectorsResponseBodyConnectors : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListConnectorsResponseBodyConnectorsApplications> Applications { get; set; }
            public class ListConnectorsResponseBodyConnectorsApplications : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pa-application-e12860ef6c48****</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>application_name</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

            }

            [NameInMap("ClusterIP")]
            [Validation(Required=false)]
            public string ClusterIP { get; set; }

            [NameInMap("ClusterPort")]
            [Validation(Required=false)]
            public string ClusterPort { get; set; }

            [NameInMap("ConnectorClients")]
            [Validation(Required=false)]
            public List<ListConnectorsResponseBodyConnectorsConnectorClients> ConnectorClients { get; set; }
            public class ListConnectorsResponseBodyConnectorsConnectorClients : TeaModel {
                [NameInMap("ConnectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                [NameInMap("DevTag")]
                [Validation(Required=false)]
                public string DevTag { get; set; }

                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

            }

            /// <summary>
            /// <para>ConnectorID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-94db94e06b98****</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-27 18:10:25</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>connector_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

            [NameInMap("UpgradeTime")]
            [Validation(Required=false)]
            public ListConnectorsResponseBodyConnectorsUpgradeTime UpgradeTime { get; set; }
            public class ListConnectorsResponseBodyConnectorsUpgradeTime : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>23:00</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20:00</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
