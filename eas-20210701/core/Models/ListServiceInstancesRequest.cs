// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceInstancesRequest : TeaModel {
        /// <summary>
        /// The keyword used to query instances. Instances can be queried based on instance name, instance IP address, IP address of the server where the instance resides, and instance type.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The IP address of the server where the instance resides.
        /// </summary>
        [NameInMap("HostIP")]
        [Validation(Required=false)]
        public string HostIP { get; set; }

        /// <summary>
        /// The IP address of the instance.
        /// </summary>
        [NameInMap("InstanceIP")]
        [Validation(Required=false)]
        public string InstanceIP { get; set; }

        /// <summary>
        /// The instance name.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The instance state.
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The instance type.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether the instance is a preemptible instance.
        /// </summary>
        [NameInMap("IsSpot")]
        [Validation(Required=false)]
        public bool? IsSpot { get; set; }

        /// <summary>
        /// The sorting order.
        /// 
        /// Valid values:
        /// 
        /// *   asc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     The instances are sorted in ascending order.
        /// 
        /// *   desc
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     The instances are sorted in descending order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The page number. Default value: 1.
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
        /// The type of the resource group to which the instance belongs.
        /// 
        /// Valid values:
        /// 
        /// *   PublicResource
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   DedicatedResource
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The service role.
        /// 
        /// Valid values:
        /// 
        /// *   DataSet
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     dataset service
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   SDProxy
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     Stable-Diffusion proxy service
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   Standard
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     standard service
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   Queue
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     queue service
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The field that you use to sort the query results.
        /// 
        /// *   Set the value to StartTime.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     The value specifies that the query results are sorted based on the time when the instances were created
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
