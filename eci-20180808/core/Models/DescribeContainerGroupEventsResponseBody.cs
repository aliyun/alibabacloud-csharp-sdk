// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupEventsResponseBody : TeaModel {
        /// <summary>
        /// Details of the events.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupEventsResponseBodyData> Data { get; set; }
        public class DescribeContainerGroupEventsResponseBodyData : TeaModel {
            /// <summary>
            /// The annotations of the elastic container instance.
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public string Annotations { get; set; }

            /// <summary>
            /// The ID of the elastic container instance.
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// The events.
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupEventsResponseBodyDataEvents> Events { get; set; }
            public class DescribeContainerGroupEventsResponseBodyDataEvents : TeaModel {
                /// <summary>
                /// The number of events.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The first occurrence time of the event.
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// The most recent occurrence time of the event.
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// The message about the event.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The metadata of the event.
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public DescribeContainerGroupEventsResponseBodyDataEventsMetadata Metadata { get; set; }
                public class DescribeContainerGroupEventsResponseBodyDataEventsMetadata : TeaModel {
                    /// <summary>
                    /// The event name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The namespace.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                /// <summary>
                /// The cause of the event.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The component from which the event is reported.
                /// </summary>
                [NameInMap("ReportingComponent")]
                [Validation(Required=false)]
                public string ReportingComponent { get; set; }

                /// <summary>
                /// The instance from which the event is reported.
                /// </summary>
                [NameInMap("ReportingInstance")]
                [Validation(Required=false)]
                public string ReportingInstance { get; set; }

                /// <summary>
                /// The source.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public DescribeContainerGroupEventsResponseBodyDataEventsSource Source { get; set; }
                public class DescribeContainerGroupEventsResponseBodyDataEventsSource : TeaModel {
                    /// <summary>
                    /// The component.
                    /// </summary>
                    [NameInMap("Component")]
                    [Validation(Required=false)]
                    public string Component { get; set; }

                    /// <summary>
                    /// The host.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                }

                /// <summary>
                /// The event type. Valid values:
                /// 
                /// *   Normal
                /// *   Warning
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The resource object that the event is about.
                /// </summary>
                [NameInMap("involvedObject")]
                [Validation(Required=false)]
                public DescribeContainerGroupEventsResponseBodyDataEventsInvolvedObject InvolvedObject { get; set; }
                public class DescribeContainerGroupEventsResponseBodyDataEventsInvolvedObject : TeaModel {
                    /// <summary>
                    /// The version of Kubernetes.
                    /// </summary>
                    [NameInMap("ApiVersion")]
                    [Validation(Required=false)]
                    public string ApiVersion { get; set; }

                    /// <summary>
                    /// The resource type.
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                    /// <summary>
                    /// The resource name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The namespace where the resource resides.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// The resource ID.
                    /// </summary>
                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                }

            }

            /// <summary>
            /// The name of the elastic container instance.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace where the elastic container instance resides.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The UUID of the elastic container instance.
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries of returned events.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
