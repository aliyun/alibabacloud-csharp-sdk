// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceListRequest : TeaModel {
        /// <summary>
        /// The server component that is exposed on the Internet.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The total number of servers that are exposed on the Internet.
        /// </summary>
        [NameInMap("ExposureComponent")]
        [Validation(Required=false)]
        public string ExposureComponent { get; set; }

        /// <summary>
        /// The ID of the region where the server resides.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("ExposureIp")]
        [Validation(Required=false)]
        public string ExposureIp { get; set; }

        /// <summary>
        /// The public IP address that is exposed on the Internet.
        /// </summary>
        [NameInMap("ExposurePort")]
        [Validation(Required=false)]
        public string ExposurePort { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The name of the server.
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public bool? HealthStatus { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the server group.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The health status of the Elastic Compute Service (ECS) instance in the scaling group. ECS instances that are not in the Running state are considered unhealthy. Valid values:
        /// 
        /// *   Healthy
        /// *   Unhealthy
        /// 
        /// Auto Scaling automatically removes unhealthy ECS instances from the scaling group and then releases the automatically created instances among the unhealthy instances.
        /// 
        /// Unhealthy ECS instances that are manually added to the scaling group are released based on the management mode of the instance lifecycle. If the lifecycle of the ECS instances is not managed by the scaling group, Auto Scaling removes the instances from the scaling group but does not release them. If the lifecycle of the ECS instances is managed by the scaling group, Auto Scaling removes the instances from the scaling group and releases them.
        /// 
        /// >  Make sure that you have sufficient balance within your account. If you have overdue payments in your account, pay-as-you-go and preemptible instances are stopped or released. For information about how the status of ECS instances changes when you have overdue payments in your account, see [Overdue payments](~~170589~~).
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The public IP address of the server.
        /// </summary>
        [NameInMap("VulStatus")]
        [Validation(Required=false)]
        public bool? VulStatus { get; set; }

    }

}
