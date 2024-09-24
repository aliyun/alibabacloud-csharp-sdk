// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateAlarmEventRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the alert events.</para>
        /// </summary>
        [NameInMap("AlarmEventIdList")]
        [Validation(Required=false)]
        public List<long?> AlarmEventIdList { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform on the alert events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>manual_handled</b>: handle the alert events.</description></item>
        /// <item><description><b>ignore</b>: igore the alert events.</description></item>
        /// <item><description><b>cancel_ignore</b>: remove the alert events from the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

    }

}
