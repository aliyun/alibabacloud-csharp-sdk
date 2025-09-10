// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaAlarmResponseBody : TeaModel {
        /// <summary>
        /// <para>Alarm ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18b3be23-b7b0-4d45-91bc-d0c331aa****</para>
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD219E2B-E687-45EE-B5F3-61FB730551B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
