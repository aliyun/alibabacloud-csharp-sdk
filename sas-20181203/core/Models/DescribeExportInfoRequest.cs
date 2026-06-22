// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExportInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the export task.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="~~ExportRecord~~">ExportRecord</a> operation to initiate an export.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

        /// <summary>
        /// <para>The ID of the member account in the resource directory.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by invoking the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
