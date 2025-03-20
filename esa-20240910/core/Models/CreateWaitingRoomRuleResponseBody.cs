// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateWaitingRoomRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Waiting room bypass rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>420072638347264</para>
        /// </summary>
        [NameInMap("WaitingRoomRuleId")]
        [Validation(Required=false)]
        public long? WaitingRoomRuleId { get; set; }

    }

}
