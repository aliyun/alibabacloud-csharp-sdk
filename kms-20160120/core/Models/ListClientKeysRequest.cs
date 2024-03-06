// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListClientKeysRequest : TeaModel {
        /// <summary>
        /// The name of the application access point (AAP).
        /// </summary>
        [NameInMap("AapName")]
        [Validation(Required=false)]
        public string AapName { get; set; }

    }

}
