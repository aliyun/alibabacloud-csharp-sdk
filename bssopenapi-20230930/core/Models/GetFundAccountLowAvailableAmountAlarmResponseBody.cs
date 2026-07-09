// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountLowAvailableAmountAlarmResponseBody : TeaModel {
        /// <summary>
        /// <para>Whether the alert is enabled</para>
        /// </summary>
        [NameInMap("AlarmEnabled")]
        [Validation(Required=false)]
        public bool? AlarmEnabled { get; set; }

        /// <summary>
        /// <para>Response structure metadata</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Alert threshold</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ThresholdAmount")]
        [Validation(Required=false)]
        public string ThresholdAmount { get; set; }

    }

}
