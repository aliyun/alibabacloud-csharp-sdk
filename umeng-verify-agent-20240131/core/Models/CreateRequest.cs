/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_verify_agent20240131.Models
{
    public class CreateRequest : TeaModel {
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("bundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("packName")]
        [Validation(Required=false)]
        public string PackName { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("schemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

        [NameInMap("signName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

    }

}
