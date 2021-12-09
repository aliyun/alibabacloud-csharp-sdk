// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ReplicationPrefixSet : TeaModel {
        /// <summary>
        /// Prefixs used to specify the object to replicate
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public List<string> Prefixs { get; set; }

    }

}
