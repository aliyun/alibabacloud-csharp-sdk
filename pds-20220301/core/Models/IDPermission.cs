// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class IDPermission : TeaModel {
        [NameInMap("disinherit_sub_group")]
        [Validation(Required=false)]
        public bool? DisinheritSubGroup { get; set; }

        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("permission")]
        [Validation(Required=false)]
        public Permission Permission { get; set; }

        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<string> Roles { get; set; }

    }

}
