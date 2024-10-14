// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ForwardInfoResponse : TeaModel {
        [NameInMap("ConnectInfo")]
        [Validation(Required=false)]
        public ForwardInfoResponseConnectInfo ConnectInfo { get; set; }
        public class ForwardInfoResponseConnectInfo : TeaModel {
            [NameInMap("Internet")]
            [Validation(Required=false)]
            public ForwardInfoResponseConnectInfoInternet Internet { get; set; }
            public class ForwardInfoResponseConnectInfoInternet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>47.111.119.114</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

            [NameInMap("Intranet")]
            [Validation(Required=false)]
            public ForwardInfoResponseConnectInfoIntranet Intranet { get; set; }
            public class ForwardInfoResponseConnectInfoIntranet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dsw-notebook-22-urz3u6cnu0uts7ej9r.dsw-5cc6083084818f60.dsw.pai.alibaba.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DNAT and privateZone are both ready.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dsw-notebook</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eip-25877c70gddh****</para>
        /// </summary>
        [NameInMap("EipAllocationId")]
        [Validation(Required=false)]
        public string EipAllocationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("SSHPublicKey")]
        [Validation(Required=false)]
        public string SSHPublicKey { get; set; }

    }

}
