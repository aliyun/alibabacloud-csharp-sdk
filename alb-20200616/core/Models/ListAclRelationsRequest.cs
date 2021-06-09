// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclRelationsRequest : TeaModel {
        /// <summary>
        /// 访问控制策略Id
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public List<string> AclIds { get; set; }

    }

}
