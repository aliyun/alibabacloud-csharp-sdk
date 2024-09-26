// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the events.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupEventsResponseBodyData> Data { get; set; }
        public class DescribeContainerGroupEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The annotations of the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;tenancy.x-k8s.io/namespace\&quot;:\&quot;redis\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public string Annotations { get; set; }

            /// <summary>
            /// <para>The ID of the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eci-uf6fonnghi50v6nq****</para>
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// <para>The events.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupEventsResponseBodyDataEvents> Events { get; set; }
            public class DescribeContainerGroupEventsResponseBodyDataEvents : TeaModel {
                /// <summary>
                /// <para>The number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The first occurrence time of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-04T09:08:04Z</para>
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// <para>The most recent occurrence time of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-04T09:08:04Z</para>
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// <para>The message about the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Started container</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The metadata of the event.</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public DescribeContainerGroupEventsResponseBodyDataEventsMetadata Metadata { get; set; }
                public class DescribeContainerGroupEventsResponseBodyDataEventsMetadata : TeaModel {
                    /// <summary>
                    /// <para>The event name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eci-uto-created-eci-for-ubuntu.167e3fb73cc7f9cb</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                /// <summary>
                /// <para>The cause of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Started</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The component from which the event is reported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReportingComponent")]
                [Validation(Required=false)]
                public string ReportingComponent { get; set; }

                /// <summary>
                /// <para>The instance from which the event is reported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReportingInstance")]
                [Validation(Required=false)]
                public string ReportingInstance { get; set; }

                /// <summary>
                /// <para>The source.</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public DescribeContainerGroupEventsResponseBodyDataEventsSource Source { get; set; }
                public class DescribeContainerGroupEventsResponseBodyDataEventsSource : TeaModel {
                    /// <summary>
                    /// <para>The component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kubelet</para>
                    /// </summary>
                    [NameInMap("Component")]
                    [Validation(Required=false)]
                    public string Component { get; set; }

                    /// <summary>
                    /// <para>The host.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eci</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                }

                /// <summary>
                /// <para>The event type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal</description></item>
                /// <item><description>Warning</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The resource object that the event is about.</para>
                /// </summary>
                [NameInMap("involvedObject")]
                [Validation(Required=false)]
                public DescribeContainerGroupEventsResponseBodyDataEventsInvolvedObject InvolvedObject { get; set; }
                public class DescribeContainerGroupEventsResponseBodyDataEventsInvolvedObject : TeaModel {
                    /// <summary>
                    /// <para>The version of Kubernetes.</para>
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
                    /// <para>The resource name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The namespace where the resource resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eci-8vb5nkcq3a5cu0p3****</para>
                    /// </summary>
                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace where the elastic container instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The UUID of the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3fc6b309-<b><b>-</b></b></para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1340C38D-6189-54D1-86F6-7D5ECF3E0088</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries of returned events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
