// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantMetricsRequest : TeaModel {
        /// <summary>
        /// The end time of the time range for querying monitoring data.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The monitoring metrics.   
        /// For more information about supported metrics, see [View tenant statistics](~~212125~~).
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// The number of the page to return.    
        /// - Start value: 1 
        /// - Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of rows to return on each page.   
        /// - Maximum value: 100   
        /// - Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The start time of the time range for querying monitoring data.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant.   
        /// > <br>This parameter will be deprecated. We recommend that you use the TenantIdList parameter instead.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantId { get; set; }

        /// <summary>
        /// The list of tenant IDs.
        /// </summary>
        [NameInMap("TenantIdList")]
        [Validation(Required=false)]
        public string TenantIdList { get; set; }

        /// <summary>
        /// The name of the tenant.    
        /// It must start with a letter or an underscore (_), and contain 2 to 20 characters, which can be uppercase letters, lowercase letters, digits, and underscores (_).  It cannot be set to sys.   
        /// > <br>This parameter will be deprecated. We recommend that you use the TenantIdList parameter instead.
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantName { get; set; }

    }

}
