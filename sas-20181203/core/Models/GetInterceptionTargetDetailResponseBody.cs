// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionTargetDetailResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the network object.
        /// </summary>
        [NameInMap("RuleTarget")]
        [Validation(Required=false)]
        public GetInterceptionTargetDetailResponseBodyRuleTarget RuleTarget { get; set; }
        public class GetInterceptionTargetDetailResponseBodyRuleTarget : TeaModel {
            /// <summary>
            /// The name of the application to which the network object belongs.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The ID of the container cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the container cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// An array that consists of the images of the network object.
            /// </summary>
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<string> ImageList { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// An array that consists of the labels specified for the network object.
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }

            /// <summary>
            /// The ID of the network object.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public long? TargetId { get; set; }

            /// <summary>
            /// The name of the network object.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The type of the network object. Valid values:
            /// 
            /// *   **IMAGE**: image
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
