// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DeleteAlarmResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the event-triggered task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1hvbnmkl10vll5****_f95ce797-dc2e-4bad-9618-14fee7d1****</para>
        /// </summary>
        [NameInMap("AlarmTaskId")]
        [Validation(Required=false)]
        public string AlarmTaskId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF9BFEE-FE07-4627-B8FB-14326FB9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
