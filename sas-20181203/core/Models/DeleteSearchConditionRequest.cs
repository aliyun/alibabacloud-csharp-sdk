// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSearchConditionRequest : TeaModel {
        /// <summary>
        /// The name of the frequently used search condition.
        /// 
        /// >  You can call the [DescribeSearchCondition](~~DescribeSearchCondition~~) operation to query frequently used search conditions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the asset. Default value: ecs. Valid values:
        /// 
        /// *   **ecs**: an Elastic Compute Service (ECS) instance.
        /// *   **cloud_product**: an Alibaba Cloud service.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
