// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectEventStatusRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the events.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public List<long?> Id { get; set; }

        /// <summary>
        /// <para>The handling status of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: unhandled</description></item>
        /// <item><description><b>1</b>: handled</description></item>
        /// <item><description><b>2</b>: added to the whitelist</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
