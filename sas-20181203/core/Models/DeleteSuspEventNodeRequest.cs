// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSuspEventNodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the note.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to obtain this parameter from the EventNotes field.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public long? NoteId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member account in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
