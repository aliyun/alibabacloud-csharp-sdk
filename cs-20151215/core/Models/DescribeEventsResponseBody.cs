// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// The details of the event.
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEvents> Events { get; set; }
        public class DescribeEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The description of the event.
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public DescribeEventsResponseBodyEventsData Data { get; set; }
            public class DescribeEventsResponseBodyEventsData : TeaModel {
                /// <summary>
                /// The severity level of the event.
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The details of the event.
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The status of the event.
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// The event ID.
            /// </summary>
            [NameInMap("event_id")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// The source of the event.
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The subject of the event.
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// The time when the event started.
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The event type. Valid values:
            /// 
            /// *   `cluster_create`: cluster creation.
            /// *   `cluster_scaleout`: cluster scale-out.
            /// *   `cluster_attach`: node addition.
            /// *   `cluster_delete`: cluster deletion.
            /// *   `cluster_upgrade`: cluster upgrades.
            /// *   `cluster_migrate`: cluster migration.
            /// *   `cluster_node_delete`: node removal.
            /// *   `cluster_node_drain`: node draining.
            /// *   `cluster_modify`: cluster modifications.
            /// *   `cluster_configuration_modify`: modifications of control plane configurations.
            /// *   `cluster_addon_install`: component installation.
            /// *   `cluster_addon_upgrade`: component updates.
            /// *   `cluster_addon_uninstall`: component uninstallation.
            /// *   `runtime_upgrade`: runtime updates.
            /// *   `nodepool_upgrade`: node pool upgrades.
            /// *   `nodepool_update`: node pool updates.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeEventsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
