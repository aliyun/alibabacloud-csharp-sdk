// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppServiceGroup : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("QrCode")]
        [Validation(Required=false)]
        public string QrCode { get; set; }

        /// <summary>
        /// <para>例如：dingtalk、wx 等</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
