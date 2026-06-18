// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class QuotaPageContentTypesValue : TeaModel {
        /// <summary>
        /// <para>Whether the Content-Type is enabled.</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The maximum content length for this Content-Type.</para>
        /// </summary>
        [NameInMap("ContentLength")]
        [Validation(Required=false)]
        public WafQuotaInteger ContentLength { get; set; }

    }

}
