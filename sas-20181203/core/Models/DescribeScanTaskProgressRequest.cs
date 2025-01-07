// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskProgressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the virus scan task.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~StartVirusScanTask~~">StartVirusScanTask</a> operation to query the IDs of virus scan tasks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>282832</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
