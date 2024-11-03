// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetWaitingRoomConfigRequest : TeaModel {
        /// <summary>
        /// <para>The percentage of requests that are allowed to be redirected to the origin server. Valid values: <b>0</b> to <b>100</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AllowPct")]
        [Validation(Required=false)]
        public int? AllowPct { get; set; }

        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The length of waiting time to skip after an exit from the queue. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("GapTime")]
        [Validation(Required=false)]
        public int? GapTime { get; set; }

        /// <summary>
        /// <para>The maximum length of waiting time in the queue. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxTimeWait")]
        [Validation(Required=false)]
        public int? MaxTimeWait { get; set; }

        /// <summary>
        /// <para>The regular expression that is used to match URI strings for which the virtual waiting room feature is enabled.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WaitUri")]
        [Validation(Required=false)]
        public string WaitUri { get; set; }

        /// <summary>
        /// <para>The URL of the waiting page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/waitingroom.html">https://example.com/waitingroom.html</a></para>
        /// </summary>
        [NameInMap("WaitUrl")]
        [Validation(Required=false)]
        public string WaitUrl { get; set; }

    }

}
