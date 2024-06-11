// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Beian20160810.Models
{
    public class SubmitAccessorFullDomainsOssListRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OssList")]
        [Validation(Required=false)]
        public List<string> OssList { get; set; }

    }

}
