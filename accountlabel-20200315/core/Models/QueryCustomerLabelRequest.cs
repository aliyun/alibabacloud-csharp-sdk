// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountLabel20200315.Models
{
    public class QueryCustomerLabelRequest : TeaModel {
        [NameInMap("Instant")]
        [Validation(Required=false)]
        public bool? Instant { get; set; }

        [NameInMap("LabelSeries")]
        [Validation(Required=false)]
        public string LabelSeries { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PK")]
        [Validation(Required=false)]
        public long? PK { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
