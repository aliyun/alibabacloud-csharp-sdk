// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeManagedInstancesResponseBody : TeaModel {
        /// <summary>
        /// The queried managed instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeManagedInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeManagedInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The ID of the activation code.
            /// </summary>
            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

            /// <summary>
            /// The version number of Cloud Assistant Agent.
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// Indicates whether the managed instance is connected. Valid values:
            /// 
            /// *   true: The managed instance is connected and you can manage the instance by using Cloud Assistant.
            /// *   false: The managed instance is not connected because the managed instance is down or because Cloud Assistant Agent is not installed correctly.
            /// </summary>
            [NameInMap("Connected")]
            [Validation(Required=false)]
            public bool? Connected { get; set; }

            /// <summary>
            /// The hostname of the managed instance.
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// The ID of the managed instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the managed instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the managed instance.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The internal IP address of the managed instance.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The number of times that Cloud Assistant tasks were executed on the managed instance.
            /// </summary>
            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }

            /// <summary>
            /// The time when the Cloud Assistant task was last executed.
            /// </summary>
            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }

            /// <summary>
            /// The machine code of the managed instance.
            /// </summary>
            [NameInMap("MachineId")]
            [Validation(Required=false)]
            public string MachineId { get; set; }

            /// <summary>
            /// The operating system type of the managed instance.
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The version information of the operating system.
            /// </summary>
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// The time when the managed instance was registered.
            /// </summary>
            [NameInMap("RegistrationTime")]
            [Validation(Required=false)]
            public string RegistrationTime { get; set; }

            /// <summary>
            /// The ID of the resource group to which the managed instance belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The tags of the managed instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeManagedInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class DescribeManagedInstancesResponseBodyInstancesTags : TeaModel {
                /// <summary>
                /// The key of tag N of the managed instance. Valid values of N: 1 to 20. The tag key cannot be an empty string.
                /// 
                /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags added, call the [ListTagResources](https://help.aliyun.com/document_detail/110425.html) operation.
                /// 
                /// The tag key can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of tag N of the managed instance. Valid values of N: 1 to 20. The tag value can be an empty string.
                /// 
                /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The query token returned in the call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// The total number of queried managed instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
