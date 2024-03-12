// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentsRequest : TeaModel {
        /// <summary>
        /// The add-on name. You must specify at least one of the AddonName and EnvironmentType parameters.
        /// </summary>
        [NameInMap("AddonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// 绑定的资源ID。
        /// </summary>
        [NameInMap("BindResourceId")]
        [Validation(Required=false)]
        public string BindResourceId { get; set; }

        /// <summary>
        /// The environment type. You must specify at least one of the AddonName and EnvironmentType parameters.
        /// 
        /// Valid values:
        /// 
        /// *   CS
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     Container Service for Kubernetes (ACK)
        /// 
        ///     <!-- -->
        /// 
        /// *   ECS
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     Elastic Compute Service (ECS)
        /// 
        ///     <!-- -->
        /// 
        /// *   Cloud
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     cloud service
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("EnvironmentType")]
        [Validation(Required=false)]
        public string EnvironmentType { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListEnvironmentsRequestTag> Tag { get; set; }
        public class ListEnvironmentsRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
