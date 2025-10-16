// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallDropStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("AclDropCnt")]
        [Validation(Required=false)]
        public long? AclDropCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("IpsDropCnt")]
        [Validation(Required=false)]
        public long? IpsDropCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA1D173-D5DB-582E-9637-438D5CE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalDropCnt")]
        [Validation(Required=false)]
        public long? TotalDropCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VulnDropCnt")]
        [Validation(Required=false)]
        public long? VulnDropCnt { get; set; }

    }

}
