// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyAlarmResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the event-triggered task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1hvbnmkl10vll5****_83948190-acdd-483f-98f7-b77f4778****</para>
        /// </summary>
        [NameInMap("AlarmTaskId")]
        [Validation(Required=false)]
        public string AlarmTaskId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BACACF83-7070-4953-A8FD-D81F89F1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
