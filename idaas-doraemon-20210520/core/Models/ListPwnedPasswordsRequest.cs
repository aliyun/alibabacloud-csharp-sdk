// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListPwnedPasswordsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PrefixHexPasswordSha1Hash")]
        [Validation(Required=false)]
        public string PrefixHexPasswordSha1Hash { get; set; }

    }

}
