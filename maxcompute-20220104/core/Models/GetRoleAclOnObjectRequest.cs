// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRoleAclOnObjectRequest : TeaModel {
        /// <summary>
        /// The name of the object.
        /// </summary>
        [NameInMap("objectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// The type of the object.
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}
