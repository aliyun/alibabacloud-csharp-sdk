// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// The time when the resource group was last updated.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListResourceGroupsResponseBodyData> Data { get; set; }
        public class ListResourceGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the resource group. The content enclosed in braces {} is the details of the resource group.
            /// </summary>
            [NameInMap("BizExtKey")]
            [Validation(Required=false)]
            public string BizExtKey { get; set; }

            /// <summary>
            /// The type of the resource group. Valid values:
            /// 
            /// *   0: DataWorks
            /// *   2: MaxCompute
            /// *   3: PAI
            /// *   4: Data Integration
            /// *   7: scheduling
            /// *   9: DataService Studio
            /// </summary>
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// The mode of the resource group. Valid values:
            /// 
            /// *   ISOLATE: exclusive resource group that adopts the subscription billing method
            /// *   SHARE: shared resource group that adopts the pay-as-you-go billing method
            /// *   DEVELOP: resource group for developers
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the cluster was created. Example: Jul 9, 2018 02:43:37 PM.
            /// </summary>
            [NameInMap("EnableKp")]
            [Validation(Required=false)]
            public bool? EnableKp { get; set; }

            /// <summary>
            /// The ID of your Alibaba Cloud resource group.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The category of the resource group. Valid values:
            /// 
            /// *   default: shared resource group
            /// *   single: exclusive resource group
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// Indicates whether the UID of an Alibaba Cloud account is used for access. Valid values:
            /// 
            /// *   true: The MaxCompute compute engine uses the UID of the Alibaba Cloud account as the display name of the account for access.
            /// 
            /// *   false: The MaxCompute compute engine uses the name of the Alibaba Cloud account as the display name of the account for access.
            /// 
            ///     The remaining values are useless. This parameter is returned only if the type of the resource group is MaxCompute.
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// The sequence number of the resource group. Created resource groups are sorted in ascending order by sequence number.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The identifier of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupType")]
            [Validation(Required=false)]
            public string ResourceGroupType { get; set; }

            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("Specs")]
            [Validation(Required=false)]
            public Dictionary<string, object> Specs { get; set; }

            /// <summary>
            /// Indicates whether the resource group is the default resource group. Valid values:
            /// 
            /// *   true: The resource group is the default resource group.
            /// *   false: The resource group is not the default resource group.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyDataTags> Tags { get; set; }
            public class ListResourceGroupsResponseBodyDataTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// The name of the cluster. This parameter is returned only if the type of the resource group is MaxCompute or PAI.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The resource groups.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the resource group. Valid values:
        /// 
        /// *   0: The resource group is running or in service.
        /// *   1: The resource group has expired and is frozen.
        /// *   2: The resource group is released or destroyed.
        /// *   3: The resource group is being created or started.
        /// *   4: The resource group fails to be created or started.
        /// *   5: The resource group is being scaled out or upgraded.
        /// *   6: The resource group fails to be scaled out or upgraded.
        /// *   7: The resource group is being released or destroyed.
        /// *   8: The resource group fails to be released or destroyed.
        /// *   9: The operation performed on the resource group times out. All operations may time out. This value is temporarily available only for DataService Studio.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
