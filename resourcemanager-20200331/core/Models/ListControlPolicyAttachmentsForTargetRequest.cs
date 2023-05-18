// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPolicyAttachmentsForTargetRequest : TeaModel {
        /// <summary>
        /// The language in which you want to return the descriptions of the access control policies. Valid values:
        /// 
        /// *   zh-CN (default value): Chinese
        /// *   en: English
        /// *   ja: Japanese
        /// 
        /// >  This parameter is valid only for system access control policies.
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The ID of the object whose access control policies you want to query. Access control policies can be attached to the following objects:
        /// 
        /// *   Root folder
        /// *   Subfolders of the Root folder
        /// *   Members
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
