// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetControlPolicyRequest : TeaModel {
        /// <summary>
        /// The language in which you want to return the description of the access control policy. Valid values:
        /// 
        /// *   zh-CN (default value): Chinese
        /// *   en: English
        /// *   ja: Japanese
        /// 
        /// > This parameter is valid only for system access control policies.
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The ID of the access control policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
