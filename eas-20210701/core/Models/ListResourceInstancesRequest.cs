// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListResourceInstancesRequest : TeaModel {
        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PrePaid: subscription.
        /// *   PostPaid: pay-as-you-go.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The keyword used to query instances. Instances can be queried by instance ID or instance IP address.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The IP address of the instance.
        /// </summary>
        [NameInMap("InstanceIP")]
        [Validation(Required=false)]
        public string InstanceIP { get; set; }

        /// <summary>
        /// The instance ID. For more information about how to query the instance ID, see [ListResourceInstances](https://help.aliyun.com/document_detail/412129.html).
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The instance name.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The instance state.
        /// 
        /// Valid values:
        /// 
        /// *   Ready-SchedulingDisabled
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     The instance is available but unschedulable
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   Ready
        /// 
        ///     <!-- -->
        /// 
        ///     : The instance
        /// 
        ///     <!-- -->
        /// 
        ///     is running
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   NotReady
        /// 
        ///     <!-- -->
        /// 
        ///     : The instance is unready.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Stopped
        /// 
        ///     <!-- -->
        /// 
        ///     : The instance has stopped.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   NotReady-SchedulingDisabled
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     The instance is unavailable and unschedulable
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   Attaching
        /// 
        ///     <!-- -->
        /// 
        ///     : The instance
        /// 
        ///     <!-- -->
        /// 
        ///     is starting
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   Deleting
        /// 
        ///     <!-- -->
        /// 
        ///     : The instance is being deleted.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   CreateFailed: The instance failed to be created.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The sorting order.
        /// 
        /// Valid values:
        /// 
        /// *   asc: The instances are sorted in ascending order.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   desc
        /// 
        ///     <!-- -->
        /// 
        ///     : The instances are sorted in descending order.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The field that you use to sort the query results.
        /// 
        /// Valid values:
        /// 
        /// *   CreateTime
        /// 
        ///     <!-- -->
        /// 
        ///     : The instances are sorted based on the time when the instances were created.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   MemoryUsed
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     The instances are sorted based on the memory usage of the instances
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   GpuUsed
        /// 
        ///     <!-- -->
        /// 
        ///     : The instances are sorted based on the
        /// 
        ///     <!-- -->
        /// 
        ///     GPU usage of the instances.
        /// 
        ///     <!-- -->
        /// 
        /// *   ExpireTime: The instances are sorted based on the time when the instances expired.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   CpuUsed
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     The instances are sorted based on the CPU utilization of the instances.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
