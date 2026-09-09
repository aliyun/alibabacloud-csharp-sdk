// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSuspEventNoteRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert event for which you want to add a note. Call <a href="https://help.aliyun.com/document_detail/251497.html">DescribeSuspEvents</a> to obtain the alert event ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>668931</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The note to add.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ignore</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>Invoke <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
