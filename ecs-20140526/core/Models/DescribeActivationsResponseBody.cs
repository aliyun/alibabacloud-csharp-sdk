// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeActivationsResponseBody : TeaModel {
        /// <summary>
        /// The activation codes and their usage information.
        /// </summary>
        [NameInMap("ActivationList")]
        [Validation(Required=false)]
        public List<DescribeActivationsResponseBodyActivationList> ActivationList { get; set; }
        public class DescribeActivationsResponseBodyActivationList : TeaModel {
            /// <summary>
            /// The ID of the activation code.
            /// </summary>
            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

            /// <summary>
            /// The time when the activation code was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The number of instances that were deregistered.
            /// </summary>
            [NameInMap("DeregisteredCount")]
            [Validation(Required=false)]
            public int? DeregisteredCount { get; set; }

            /// <summary>
            /// The description of the activation code.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the activation code is disabled.
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// The maximum number of times that the activation code can be used to register managed instances.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The default instance name prefix.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The IP addresses of hosts that are allowed to use the activation code.
            /// </summary>
            [NameInMap("IpAddressRange")]
            [Validation(Required=false)]
            public string IpAddressRange { get; set; }

            /// <summary>
            /// The number of instances that were registered.
            /// </summary>
            [NameInMap("RegisteredCount")]
            [Validation(Required=false)]
            public int? RegisteredCount { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The tags of the activation code.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeActivationsResponseBodyActivationListTags> Tags { get; set; }
            public class DescribeActivationsResponseBodyActivationListTags : TeaModel {
                /// <summary>
                /// The tag key of the activation code.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the activation code.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The validity period of the activation code. Unit: hours.
            /// </summary>
            [NameInMap("TimeToLiveInHours")]
            [Validation(Required=false)]
            public long? TimeToLiveInHours { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
