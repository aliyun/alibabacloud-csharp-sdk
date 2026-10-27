// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyOpenLogShipperRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the request source. Default value: <b>aegis</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>aegis</b>: Server Guard edition.</description></item>
        /// <item><description><b>sas</b>: Security Center edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you use Server Guard, set this parameter to <b>aegis</b>. If you use Security Center, set this parameter to <b>sas</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts (Alibaba Cloud account) in the resource folder.</para>
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
