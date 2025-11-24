// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeImportedServicesDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the services.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeImportedServicesDetailResponseBodyDetails> Details { get; set; }
        public class DescribeImportedServicesDetailResponseBodyDetails : TeaModel {
            /// <summary>
            /// <para>The clusters on the data plane.</para>
            /// </summary>
            [NameInMap("ClusterIds")]
            [Validation(Required=false)]
            public List<string> ClusterIds { get; set; }

            /// <summary>
            /// <para>The labels of the service.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// <para>The namespace in which the service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The ports declared for the service.</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeImportedServicesDetailResponseBodyDetailsPorts> Ports { get; set; }
            public class DescribeImportedServicesDetailResponseBodyDetailsPorts : TeaModel {
                /// <summary>
                /// <para>The name of a port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http-0</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("NodePort")]
                [Validation(Required=false)]
                public int? NodePort { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol of the port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The container port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// <para>The name of a service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>productpage</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The type of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Kubernetes</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0496204-7586-5B4C-B364-2361CC0EDxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
