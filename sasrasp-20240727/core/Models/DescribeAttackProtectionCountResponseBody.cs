// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SasRasp20240727.Models
{
    public class DescribeAttackProtectionCountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BlockHighCount")]
        [Validation(Required=false)]
        public long? BlockHighCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BlockLowCount")]
        [Validation(Required=false)]
        public long? BlockLowCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BlockMediumCount")]
        [Validation(Required=false)]
        public long? BlockMediumCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MonitorHighCount")]
        [Validation(Required=false)]
        public long? MonitorHighCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MonitorLowCount")]
        [Validation(Required=false)]
        public long? MonitorLowCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MonitorMediumCount")]
        [Validation(Required=false)]
        public long? MonitorMediumCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>400E8C8C-ADD3-5F25-9038-BDC057841D20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>61134279</para>
        /// </summary>
        [NameInMap("TotalRequestCount")]
        [Validation(Required=false)]
        public long? TotalRequestCount { get; set; }

    }

}
