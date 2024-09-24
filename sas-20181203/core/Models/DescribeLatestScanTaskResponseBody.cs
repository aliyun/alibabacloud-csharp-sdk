// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLatestScanTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1671610264000</para>
        /// </summary>
        [NameInMap("LastCheckTime")]
        [Validation(Required=false)]
        public long? LastCheckTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42XXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskNum")]
        [Validation(Required=false)]
        public int? RiskNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;uuid&quot;,&quot;name&quot;:&quot;Host001&quot;,&quot;target&quot;:&quot;503201a7-14c6-4280-801b-1169ed42****&quot;}]</para>
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
