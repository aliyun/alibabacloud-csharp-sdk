// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateInlinePolicyForAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// The ID of the access configuration.
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The name of the inline policy.
        /// </summary>
        [NameInMap("InlinePolicyName")]
        [Validation(Required=false)]
        public string InlinePolicyName { get; set; }

        /// <summary>
        /// The new configurations of the inline policy.
        /// 
        /// The value can be up to 4,096 characters in length.
        /// 
        /// For more information about the syntax and structure of RAM policies, see [Policy syntax and structure](~~93739~~).
        /// </summary>
        [NameInMap("NewInlinePolicyDocument")]
        [Validation(Required=false)]
        public string NewInlinePolicyDocument { get; set; }

    }

}
