// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetRoleRequest : TeaModel {
        /// <summary>
        /// The language that is used to return the description of the RAM role. Valid values:
        /// 
        /// *   en: English
        /// *   zh-CN: Chinese
        /// *   ja: Japanese
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The name of the RAM role.
        /// 
        /// The name must be 1 to 64 characters in length and can contain letters, digits, periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
