// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class CreateControlPolicyRequest : TeaModel {
        /// <summary>
        /// The description of the access control policy.
        /// 
        /// The description must be 1 to 1,024 characters in length. The description can contain letters, digits, underscores (_), and hyphens (-) and must start with a letter.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The effective scope of the access control policy.
        /// 
        /// The value RAM indicates that the access control policy takes effect only for RAM users and RAM roles.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EffectScope")]
        [Validation(Required=false)]
        public string EffectScope { get; set; }

        /// <summary>
        /// The document of the access control policy.
        /// 
        /// The document can be a maximum of 4,096 characters in length.
        /// 
        /// For more information about the languages of access control policies, see [Languages of access control policies](https://help.aliyun.com/document_detail/179096.html).
        /// 
        /// For more information about the examples of access control policies, see [Examples of custom access control policies](https://help.aliyun.com/document_detail/181474.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// The name of the access control policy.
        /// 
        /// The name must be 1 to 128 characters in length. The name can contain letters, digits, and hyphens (-) and must start with a letter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateControlPolicyRequestTag> Tag { get; set; }
        public class CreateControlPolicyRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
