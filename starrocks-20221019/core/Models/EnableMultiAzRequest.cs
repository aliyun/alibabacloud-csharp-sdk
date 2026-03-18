// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class EnableMultiAzRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c-238sjh237s12***</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("observers")]
        [Validation(Required=false)]
        public List<EnableMultiAzRequestObservers> Observers { get; set; }
        public class EnableMultiAzRequestObservers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-x1232js012</para>
            /// </summary>
            [NameInMap("vswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
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
