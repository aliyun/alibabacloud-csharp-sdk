// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveSuspEventUserSettingRequest : TeaModel {
        /// <summary>
        /// <para>The source of the exception event data. Set the value to sas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The alert level for alert notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>remind</b>: Reminder.</description></item>
        /// <item><description><b>suspicious</b>: Suspicious.</description></item>
        /// <item><description><b>serious</b>: Urgent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>suspicious,serious,remind</para>
        /// </summary>
        [NameInMap("LevelsOn")]
        [Validation(Required=false)]
        public string LevelsOn { get; set; }

        /// <summary>
        /// <para>The ID of the member account in the resource directory.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
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
