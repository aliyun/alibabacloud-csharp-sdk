// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreatePrivateAccessPolicyRequest : TeaModel {
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        [NameInMap("CustomUserAttributes")]
        [Validation(Required=false)]
        public List<CreatePrivateAccessPolicyRequestCustomUserAttributes> CustomUserAttributes { get; set; }
        public class CreatePrivateAccessPolicyRequestCustomUserAttributes : TeaModel {
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public int? IdpId { get; set; }

            [NameInMap("Relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public string UserGroupType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DeviceAttributeAction")]
        [Validation(Required=false)]
        public string DeviceAttributeAction { get; set; }

        [NameInMap("DeviceAttributeId")]
        [Validation(Required=false)]
        public string DeviceAttributeId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 内网访问标签ID集合。最多可输入100个内网访问标签ID。当**ApplicationType**为**Tag时**，必填。和**ApplicationIds**互斥。
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// 内网访问策略的用户组类型。取值：
        /// - **Normal**：普通用户组。
        /// - **Custom**：自定义用户组。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserGroupMode")]
        [Validation(Required=false)]
        public string UserGroupMode { get; set; }

    }

}
