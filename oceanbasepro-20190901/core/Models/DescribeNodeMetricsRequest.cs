// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeNodeMetricsRequest : TeaModel {
        /// <summary>
        /// $.parameters[7].schema.description
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The list of nodes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// $.parameters[7].schema.enumValueTitles
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// $.parameters[10].schema.description
        /// </summary>
        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public string NodeIdList { get; set; }

        /// <summary>
        /// $.parameters[8].schema.example
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// $.parameters[6].schema.description
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// $.parameters[9].schema.example
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// $.parameters[6].schema.enumValueTitles
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
