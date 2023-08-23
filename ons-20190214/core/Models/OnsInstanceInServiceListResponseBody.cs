// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceInServiceListResponseBody : TeaModel {
        /// <summary>
        /// The returned list of all published instances.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsInstanceInServiceListResponseBodyData Data { get; set; }
        public class OnsInstanceInServiceListResponseBodyData : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<OnsInstanceInServiceListResponseBodyDataInstanceVO> InstanceVO { get; set; }
            public class OnsInstanceInServiceListResponseBodyDataInstanceVO : TeaModel {
                /// <summary>
                /// The time when the instance was created. The value of this parameter is a UNIX timestamp in milliseconds.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("GroupCount")]
                [Validation(Required=false)]
                public int? GroupCount { get; set; }

                /// <summary>
                /// Indicates whether the instance uses a namespace. Valid values:
                /// 
                /// *   **true**: The instance uses a separate namespace. The name of each resource must be unique in the instance. The names of resources in different instances can be the same.
                /// *   **false**: The instance does not use a separate namespace. The name of each resource must be globally unique within the instance and across all instances.
                /// </summary>
                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                /// <summary>
                /// The ID of the instance
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// 
                /// The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (\_).
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// *   **0**: The instance is being deployed. This value is valid only for Enterprise Platinum Edition instances.
                /// *   **2**: The instance has overdue payments. This value is valid only for Standard Edition instances.
                /// *   **5**: The instance is running. This value is valid for Standard Edition instances and Enterprise Platinum Edition instances.
                /// *   **7**: The instance is being upgraded and is running. This value is valid only for Enterprise Platinum Edition instances.
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public int? InstanceStatus { get; set; }

                /// <summary>
                /// The instance type. Valid values:
                /// 
                /// *   **1**: Standard Edition instances
                /// *   **2**: Enterprise Platinum Edition instances
                /// 
                /// For more information about the instance editions and differences between the editions, see [Instance editions](~~185261~~).
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public int? InstanceType { get; set; }

                /// <summary>
                /// The time when the instance expires. If the instance is an Enterprise Platinum Edition instance, this parameter is returned.
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                /// <summary>
                /// The tags that are attached to the instance you want to query.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public OnsInstanceInServiceListResponseBodyDataInstanceVOTags Tags { get; set; }
                public class OnsInstanceInServiceListResponseBodyDataInstanceVOTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsInstanceInServiceListResponseBodyDataInstanceVOTagsTag> Tag { get; set; }
                    public class OnsInstanceInServiceListResponseBodyDataInstanceVOTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag that is attached to the instance.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag that is attached to the instance.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TopicCount")]
                [Validation(Required=false)]
                public int? TopicCount { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
