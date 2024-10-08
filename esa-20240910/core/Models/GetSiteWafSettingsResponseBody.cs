// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteWafSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public WafSiteSettings Settings { get; set; }

    }

}
