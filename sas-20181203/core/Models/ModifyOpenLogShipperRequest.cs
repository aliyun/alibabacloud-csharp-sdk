// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyOpenLogShipperRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the request source. Default value: <b>aegis</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>aegis</b>: Server Guard</description></item>
        /// <item><description><b>sas</b>: Security Center</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you use Server Guard, set the value to <b>aegis</b>. If you use Security Center, set the value to <b>sas</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the IDs.</para>
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
