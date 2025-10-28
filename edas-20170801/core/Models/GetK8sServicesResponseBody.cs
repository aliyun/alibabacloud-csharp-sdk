// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the change process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4823-bhjf-23u4-eiufh</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of services in the Kubernetes cluster.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<GetK8sServicesResponseBodyServices> Services { get; set; }
        public class GetK8sServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>The IP address of the service in the Kubernetes cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>104.23.xx.xx</para>
            /// </summary>
            [NameInMap("ClusterIP")]
            [Validation(Required=false)]
            public string ClusterIP { get; set; }

            /// <summary>
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-http</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The mapping of service ports.</para>
            /// </summary>
            [NameInMap("ServicePorts")]
            [Validation(Required=false)]
            public List<GetK8sServicesResponseBodyServicesServicePorts> ServicePorts { get; set; }
            public class GetK8sServicesResponseBodyServicesServicePorts : TeaModel {
                /// <summary>
                /// <para>The port of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NodePort")]
                [Validation(Required=false)]
                public int? NodePort { get; set; }

                /// <summary>
                /// <para>The frontend service port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The backend container port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public string TargetPort { get; set; }

            }

            /// <summary>
            /// <para>The type of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterIP</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
