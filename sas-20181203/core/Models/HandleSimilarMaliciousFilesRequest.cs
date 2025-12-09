// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSimilarMaliciousFilesRequest : TeaModel {
        /// <summary>
        /// <para>Target alert ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>Language type for request and response messages. Values include:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Handling action:</para>
        /// <list type="bullet">
        /// <item><description>addWhitelist: Add to whitelist;</description></item>
        /// <item><description>offWhitelist: Remove from whitelist;</description></item>
        /// <item><description>offline_handled: Handled offline;</description></item>
        /// <item><description>mark_mis_info: Report as false positive;</description></item>
        /// <item><description>ignore: Ignore.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>File source. Values include:</para>
        /// <list type="bullet">
        /// <item><description>agentless: Host detection;</description></item>
        /// <item><description>ecs_snapshot: User snapshot detection;</description></item>
        /// <item><description>ecs_image: User-defined image detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRange { get; set; }

        /// <summary>
        /// <para>Batch processing scenario:</para>
        /// <list type="bullet">
        /// <item><description>same_file_md5: Same file MD5;</description></item>
        /// <item><description>default (default value): Same alert type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>same_file_md5</para>
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

    }

}
