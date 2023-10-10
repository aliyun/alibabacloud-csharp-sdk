// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DescribeAppInstanceListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The application instances.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeAppInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeAppInstanceListResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// Indicates whether the application was released in canary release mode.
            /// 
            /// *   `true`: The application was released in canary release mode.
            /// *   `false`: The application was not released in canary release mode
            /// </summary>
            [NameInMap("Canary")]
            [Validation(Required=false)]
            public bool? Canary { get; set; }

            /// <summary>
            /// The ID of the instance group to which the application is deployed.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the instance group to which the application is deployed.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The labels of the node. The value is a JSON string.
            /// </summary>
            [NameInMap("NodeLabels")]
            [Validation(Required=false)]
            public string NodeLabels { get; set; }

            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The information about the pod. The value is a JSON string.
            /// </summary>
            [NameInMap("PodRaw")]
            [Validation(Required=false)]
            public string PodRaw { get; set; }

            /// <summary>
            /// The deployment package version of the node.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The message that is returned.
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
