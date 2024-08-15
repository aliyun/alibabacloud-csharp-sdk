// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSQLDetailsRequest : TeaModel {
        /// <summary>
        /// The name of the database.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DynamicSql")]
        [Validation(Required=false)]
        public bool? DynamicSql { get; set; }

        /// <summary>
        /// The end time of querying the SQL execution plan.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ParseTable")]
        [Validation(Required=false)]
        public bool? ParseTable { get; set; }

        /// <summary>
        /// SQL ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        /// <summary>
        /// The start time of querying the SQL execution plan.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
