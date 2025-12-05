// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetDeploymentsByIpRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10.100.2.200</para>
        /// </summary>
        [NameInMap("dstIp")]
        [Validation(Required=false)]
        public string DstIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9092</para>
        /// </summary>
        [NameInMap("dstPort")]
        [Validation(Required=false)]
        public string DstPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ignoreJobSummary")]
        [Validation(Required=false)]
        public bool? IgnoreJobSummary { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ignoreResourceSetting")]
        [Validation(Required=false)]
        public bool? IgnoreResourceSetting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.1.100</para>
        /// </summary>
        [NameInMap("srcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>54321</para>
        /// </summary>
        [NameInMap("srcPort")]
        [Validation(Required=false)]
        public string SrcPort { get; set; }

    }

}
