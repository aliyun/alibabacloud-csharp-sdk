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
                /// The application information.
                /// 
                /// >  This parameter is emtryp if the working mode is Desktop.
                /// </summary>
                [NameInMap("AppList")]
                [Validation(Required=false)]
                public DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppList AppList { get; set; }
                public class DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppList : TeaModel {
                    [NameInMap("AppInfo")]
                    [Validation(Required=false)]
                    public List<DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppListAppInfo> AppInfo { get; set; }
                    public class DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppListAppInfo : TeaModel {
                        /// <summary>
                        /// The runtime parameters of the application.
                        /// </summary>
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
                        /// The running path of the application.
                        /// </summary>
                        [NameInMap("AppPath")]
                        [Validation(Required=false)]
                        public string AppPath { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the visualization cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The time at which the visualization instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time at which the visualization instance expires.
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
                /// *   Creating
                /// *   Starting
                /// *   Stopping
                /// *   Stopped
                /// *   Initializing
                /// *   Unregistered
                /// *   Registered
                /// *   InUse
                /// *   Missing
                /// *   Cloning: The image is being created.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The username assigned to the visualization instance.
                /// 
                /// >  This parameter is empty if the instance is not assigned to specified users.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// The working mode of the visualization instance. Valid values:
                /// 
                /// *   Desktop: the desktop mode
                /// *   Application: the application mode
                /// </summary>
                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

        }

        /// <summary>
        /// The page number.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the information.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
