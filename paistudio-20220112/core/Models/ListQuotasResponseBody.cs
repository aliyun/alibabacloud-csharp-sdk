// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotasResponseBody : TeaModel {
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<Quota> Quotas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F082BD0D-21E1-5F9B-81A0-AB07485B03CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
