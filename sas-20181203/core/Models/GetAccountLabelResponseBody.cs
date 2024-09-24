// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAccountLabelResponseBody : TeaModel {
        [NameInMap("AccountLabelList")]
        [Validation(Required=false)]
        public List<GetAccountLabelResponseBodyAccountLabelList> AccountLabelList { get; set; }
        public class GetAccountLabelResponseBodyAccountLabelList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SasStep</para>
            /// </summary>
            [NameInMap("LabelSeries")]
            [Validation(Required=false)]
            public string LabelSeries { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LabelStatus")]
            [Validation(Required=false)]
            public bool? LabelStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
