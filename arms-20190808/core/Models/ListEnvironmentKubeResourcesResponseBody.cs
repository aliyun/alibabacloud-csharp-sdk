// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentKubeResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvironmentKubeResourcesResponseBodyData> Data { get; set; }
        public class ListEnvironmentKubeResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The version number of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("ApiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pod</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public ListEnvironmentKubeResourcesResponseBodyDataMetadata Metadata { get; set; }
            public class ListEnvironmentKubeResourcesResponseBodyDataMetadata : TeaModel {
                /// <summary>
                /// <para>The annotations.</para>
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public Dictionary<string, string> Annotations { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>The resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arms-prometheus-ack-arms-prometheus-c577b6cc8-mvdwd</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arms-prom</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

            /// <summary>
            /// <para>The resource specifications.</para>
            /// 
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
            /// <para>The status of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public object Status { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C21AB7CF-B7AF-410F-BD61-82D1567F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
