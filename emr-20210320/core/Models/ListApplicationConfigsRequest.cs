// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListApplicationConfigsRequest : TeaModel {
        /// <summary>
        /// The name of the application.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the configuration file.
        /// </summary>
        [NameInMap("ConfigFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        /// <summary>
        /// The name of the configuration item.
        /// </summary>
        [NameInMap("ConfigItemKey")]
        [Validation(Required=false)]
        public string ConfigItemKey { get; set; }

        /// <summary>
        /// The value of the configuration item.
        /// </summary>
        [NameInMap("ConfigItemValue")]
        [Validation(Required=false)]
        public string ConfigItemValue { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The page number of the next page returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the node group.
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// The node ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
