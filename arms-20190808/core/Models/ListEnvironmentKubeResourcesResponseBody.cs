// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentKubeResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvironmentKubeResourcesResponseBodyData> Data { get; set; }
        public class ListEnvironmentKubeResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("ApiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pod</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public ListEnvironmentKubeResourcesResponseBodyDataMetadata Metadata { get; set; }
            public class ListEnvironmentKubeResourcesResponseBodyDataMetadata : TeaModel {
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public Dictionary<string, string> Annotations { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>arms-prometheus-ack-arms-prometheus-c577b6cc8-mvdwd</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>arms-prom</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;dnsPolicy&quot;: &quot;ClusterFirst&quot;,
            ///         &quot;nodeName&quot;: &quot;cn-hangzhou.172.16.0.60&quot;,
            ///         &quot;terminationGracePeriodSeconds&quot;: 30,
            ///         &quot;enableServiceLinks&quot;: true,
            ///         &quot;serviceAccountName&quot;: &quot;arms-prom-operator&quot;,
            ///         &quot;volumes&quot;: [
            ///           {
            ///             &quot;name&quot;: &quot;certs&quot;,
            ///             &quot;secret&quot;: {
            ///               &quot;secretName&quot;: &quot;arms-prometheus-ack-arms-prometheus-cert&quot;,
            ///               &quot;defaultMode&quot;: 420
            ///             }
            ///           }</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public object Spec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>run</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public object Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C21AB7CF-B7AF-410F-BD61-82D1567F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
