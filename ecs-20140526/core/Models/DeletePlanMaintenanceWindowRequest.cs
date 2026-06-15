// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeletePlanMaintenanceWindowRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the maintenance window to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pw-bp12kkvnebe7hksqnx9w</para>
        /// </summary>
        [NameInMap("PlanWindowId")]
        [Validation(Required=false)]
        public string PlanWindowId { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to retrieve the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
