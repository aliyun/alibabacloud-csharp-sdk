// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class QuotaPageContentTypesValue : TeaModel {
        /// <summary>
        /// <para>Indicates whether the custom error pages of the Content-Type are configured.</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The maximum length of the custom error pages of the Content-Type.</para>
        /// </summary>
        [NameInMap("ContentLength")]
        [Validation(Required=false)]
        public WafQuotaInteger ContentLength { get; set; }

    }

}
