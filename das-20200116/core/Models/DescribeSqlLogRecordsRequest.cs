// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogRecordsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Specify the time in the UNIX timestamp format. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeSqlLogRecordsRequestFilters> Filters { get; set; }
        public class DescribeSqlLogRecordsRequestFilters : TeaModel {
            /// <summary>
            /// The name of the filter parameter.
            /// 
            /// >  For more information about the supported filter parameters and their valid values, see the following **supplement about the Key parameter**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the filter parameter.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the database instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The node ID.
        /// 
        /// *   For ApsaraDB RDS for MySQL and PolarDB for MySQL, this parameter is available only for Cluster Edition instances. By default, if this parameter is not specified, the information about the logs of the primary node is returned.
        /// *   Set this parameter to **polarx_cn** or **polarx_dn** if the node that you want to query belongs to a PolarDB-X 2.0 database instance. A value of polarx_cn indicates a compute node. A value of polarx_dn indicates a data node.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The role of the node of the PolarDB-X 2.0 database instance. Valid values:
        /// 
        /// *   \\*\\*polarx_cn\\*\\*: compute node
        /// *   \\*\\*polarx_dn\\*\\*: data node
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the UNIX timestamp format. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
