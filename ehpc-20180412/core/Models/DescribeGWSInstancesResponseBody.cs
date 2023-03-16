// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeGWSInstancesResponseBody : TeaModel {
        /// <summary>
        /// The list of visualization instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeGWSInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeGWSInstancesResponseBodyInstances : TeaModel {
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public List<DescribeGWSInstancesResponseBodyInstancesInstanceInfo> InstanceInfo { get; set; }
            public class DescribeGWSInstancesResponseBodyInstancesInstanceInfo : TeaModel {
                /// <summary>
                /// The list of application information.
                /// 
                /// >  If the WorkMode parameter is set to Desktop, an empty value is returned in this parameter.
                /// </summary>
                [NameInMap("AppList")]
                [Validation(Required=false)]
                public DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppList AppList { get; set; }
                public class DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppList : TeaModel {
                    [NameInMap("AppInfo")]
                    [Validation(Required=false)]
                    public List<DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppListAppInfo> AppInfo { get; set; }
                    public class DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppListAppInfo : TeaModel {
                        [NameInMap("AppArgs")]
                        [Validation(Required=false)]
                        public string AppArgs { get; set; }

                        /// <summary>
                        /// The name of the application.
                        /// </summary>
                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        /// <summary>
                        /// The execution directory of the application.
                        /// </summary>
                        [NameInMap("AppPath")]
                        [Validation(Required=false)]
                        public string AppPath { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the visualizatio service.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The time when the visualization instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the visualization instance expires.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The ID of the visualization instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The type of the visualization instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The name of the visualization instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the visualization instance. Valid values:
                /// 
                /// *   Creating: The instance is being created.
                /// *   Starting: The instance is being started.
                /// *   Stopping: The instance is being stopped.
                /// *   Stopped: The instance is stopped.
                /// *   Initializing: The instance is being initialized.
                /// *   Unregistered: The instance is not registered.
                /// *   Registered: The instance is registered.
                /// *   InUse: The instance is in use.
                /// *   Missing: The instance cannot be found.
                /// *   Cloning: An image is being generated based on the instance.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The username of the entity to which the visualization instance is assigned.
                /// 
                /// >  If the instance is not assigned to a specified user, this parameter is empty.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// The working mode of the visualization instance. Valid values:
                /// 
                /// *   Desktop
                /// *   Application
                /// </summary>
                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

        }

        /// <summary>
        /// The page number of the current page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
