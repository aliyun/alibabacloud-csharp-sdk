// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertDeployGroupResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the instance group.
        /// </summary>
        [NameInMap("DeployGroupEntity")]
        [Validation(Required=false)]
        public InsertDeployGroupResponseBodyDeployGroupEntity DeployGroupEntity { get; set; }
        public class InsertDeployGroupResponseBodyDeployGroupEntity : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The version of the deployment package for the application.
            /// 
            /// *   If the application is deployed, a string of random numbers is returned.
            /// *   If the application is not deployed, the return value is empty.
            /// </summary>
            [NameInMap("AppVersionId")]
            [Validation(Required=false)]
            public string AppVersionId { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The time when the instance group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The name of the instance group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The type of the instance group. Valid values:
            /// 
            /// *   0: the default group.
            /// *   1: a group for which canary traffic management is not enabled.
            /// *   2: a group for which canary traffic management is enabled.
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public int? GroupType { get; set; }

            /// <summary>
            /// The ID of the instance group.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The version of the deployment package that was used to deploy an application in the instance group.
            /// 
            /// *   If an application is deployed in the instance group, a string of random numbers is returned.
            /// *   If no application is deployed in the instance group, the return value is empty.
            /// </summary>
            [NameInMap("PackageVersionId")]
            [Validation(Required=false)]
            public string PackageVersionId { get; set; }

            /// <summary>
            /// The time when the instance group was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
