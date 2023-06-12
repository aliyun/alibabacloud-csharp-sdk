// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessPolicyRequest : TeaModel {
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        [NameInMap("CustomUserAttributes")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessPolicyRequestCustomUserAttributes> CustomUserAttributes { get; set; }
        public class UpdatePrivateAccessPolicyRequestCustomUserAttributes : TeaModel {
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

        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 内网访问标签ID集合。一条策略最多支持100个内网访问标签ID。
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
        /// </summary>
        [NameInMap("UserGroupMode")]
        [Validation(Required=false)]
        public string UserGroupMode { get; set; }

    }

}
