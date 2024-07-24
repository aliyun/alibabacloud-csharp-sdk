// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class UpgradeMultiZoneClusterResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>C532A4D4-9451-4460-BB3E-300FEC852D3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LINDORM</para>
        /// </summary>
        [NameInMap("UpgradingComponents")]
        [Validation(Required=false)]
        public string UpgradingComponents { get; set; }

    }

}
