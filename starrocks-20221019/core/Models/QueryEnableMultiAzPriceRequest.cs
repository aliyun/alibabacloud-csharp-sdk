// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryEnableMultiAzPriceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c-8dsy12g*****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("observers")]
        [Validation(Required=false)]
        public List<QueryEnableMultiAzPriceRequestObservers> Observers { get; set; }
        public class QueryEnableMultiAzPriceRequestObservers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-9sdur12t27s</para>
            /// </summary>
            [NameInMap("vswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai-h</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>youhuiquan_12378dfj6</para>
        /// </summary>
        [NameInMap("promotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

    }

}
