// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SetFundAccountLowAvailableAmountAlarmResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>08108BF5-1AA3-518E-9986-95A3616E8DA9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
