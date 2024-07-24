// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class UpgradeMinorVersionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7B8EC240-BB13-4DBC-B955-F90170E82609</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HADOOP</para>
        /// </summary>
        [NameInMap("UpgradingComponents")]
        [Validation(Required=false)]
        public string UpgradingComponents { get; set; }

    }

}
