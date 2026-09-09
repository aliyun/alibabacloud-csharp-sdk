// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperationCancelIgnoreSuspEventRequest : TeaModel {
        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark text</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member account in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The list of alert IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<long?> SecurityEventIds { get; set; }

    }

}
