// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitCheckRequest : TeaModel {
        /// <summary>
        /// <para>The check items that are scanned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FULL</b>: All check items are scanned.</description></item>
        /// <item><description><b>FULL</b>: Only the check items that are configured are scanned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POLICY</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRange { get; set; }

    }

}
