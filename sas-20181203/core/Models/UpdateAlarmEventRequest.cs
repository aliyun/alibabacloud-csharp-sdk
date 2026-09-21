// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateAlarmEventRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert event IDs.</para>
        /// <para>You can call ListHoneypotAlarmEvents to obtain valid alert event IDs. Before calling this operation, ensure that honeypots are deployed and honeypot alert event data exists.</para>
        /// <para>This parameter is required. If this parameter is not specified, the API returns HTTP 400 with the error code IllegalParam.</para>
        /// </summary>
        [NameInMap("AlarmEventIdList")]
        [Validation(Required=false)]
        public List<long?> AlarmEventIdList { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The processing method for the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>manual_handled</b>: Handled.</description></item>
        /// <item><description><b>ignore</b>: Ignored.</description></item>
        /// <item><description><b>cancel_ignore</b>: Removed from the whitelist.</description></item>
        /// </list>
        /// <para>This parameter is required. If this parameter is not specified, the API returns HTTP 400 with the error code IllegalParam.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
