// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRIUtilizationDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the instance whose fees are deducted by using the RI. If this parameter is left empty, the usage details of all instances are queried.
        /// </summary>
        [NameInMap("DeductedInstanceId")]
        [Validation(Required=false)]
        public string DeductedInstanceId { get; set; }

        /// <summary>
        /// The time when the RI expires. Specify the time in the YYYY-MM-DD HH:mm:ss format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The instance type of the RI.
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. Maximum value: 300.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The code of the service to which the RI is applied. Default value: ecsRi. Valid values:
        /// 
        /// *   ecsRi: ECS RI.
        /// *   scu_bag: storage capacity unit (SCU).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RICommodityCode")]
        [Validation(Required=false)]
        public string RICommodityCode { get; set; }

        /// <summary>
        /// The ID of the RI. If this parameter is left empty, the usage details of all RIs are queried.
        /// </summary>
        [NameInMap("RIInstanceId")]
        [Validation(Required=false)]
        public string RIInstanceId { get; set; }

        /// <summary>
        /// The time when the RI was created. Specify the time in the YYYY-MM-DD HH:mm:ss format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
