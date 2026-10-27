// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDeepAnalyzeRequest : TeaModel {
        /// <summary>
        /// <para>The request context information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        /// <summary>
        /// <para>The event ID. If a file-related alert event already exists, you can use this parameter to trigger deep analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000001</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The file hash. If the file already exists in the cloud, you can use this parameter to trigger deep analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
        /// </summary>
        [NameInMap("Hash")]
        [Validation(Required=false)]
        public string Hash { get; set; }

        /// <summary>
        /// <para>The request source. The system verifies the purchased edition based on the request source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>edr</b>: AgenticEDR.</para>
        /// </description></item>
        /// <item><description><para><b>secOpsAgent</b>: Security operations agent.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>edr</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
