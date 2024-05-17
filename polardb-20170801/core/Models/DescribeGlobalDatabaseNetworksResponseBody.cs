// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDatabaseNetworksResponseBody : TeaModel {
        /// <summary>
        /// Details about the GDNs.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeGlobalDatabaseNetworksResponseBodyItems> Items { get; set; }
        public class DescribeGlobalDatabaseNetworksResponseBodyItems : TeaModel {
            /// <summary>
            /// The time when the GDN was created. The time is in the `YYYY-MM-DDThh:mm:ssZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Details about clusters in the GDN.
            /// </summary>
            [NameInMap("DBClusters")]
            [Validation(Required=false)]
            public List<DescribeGlobalDatabaseNetworksResponseBodyItemsDBClusters> DBClusters { get; set; }
            public class DescribeGlobalDatabaseNetworksResponseBodyItemsDBClusters : TeaModel {
                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The region ID of the cluster.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The role of the cluster. Valid values:
                /// 
                /// *   **Primary**: the primary cluster
                /// *   **standby**: the secondary cluster
                /// 
                /// > A GDN consists of one primary cluster and up to four secondary clusters. For more information, see [GDN](https://help.aliyun.com/document_detail/160381.html).
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// The type of the database engine. Only **MySQL** is supported.
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// The version of the database engine. Only the **8.0** version is supported.
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// The description of the GDN. The description must meet the following requirements:
            /// 
            /// *   It cannot start with `http://` or `https://`.
            /// *   It must start with a letter.
            /// *   It can contain letters, digits, underscores (_), and hyphens (-).
            /// *   It must be 2 to 126 characters in length.
            /// </summary>
            [NameInMap("GDNDescription")]
            [Validation(Required=false)]
            public string GDNDescription { get; set; }

            /// <summary>
            /// The ID of the GDN.
            /// </summary>
            [NameInMap("GDNId")]
            [Validation(Required=false)]
            public string GDNId { get; set; }

            /// <summary>
            /// The status of the GDN. Valid values:
            /// 
            /// *   **Creating**: The GDN is being created.
            /// *   **active**: The GDN is running.
            /// *   **deleting**: The GDN is being deleted.
            /// *   **locked**: The GDN is locked. If the GDN is locked, you cannot perform operations on clusters in the GDN.
            /// *   **removing_member**: The secondary cluster is being removed from the GDN.
            /// </summary>
            [NameInMap("GDNStatus")]
            [Validation(Required=false)]
            public string GDNStatus { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of records on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
