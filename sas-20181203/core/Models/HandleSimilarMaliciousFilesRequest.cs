// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSimilarMaliciousFilesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the target alert.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The handling action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>addWhitelist: adds to the whitelist.</description></item>
        /// <item><description>offWhitelist: removes from the whitelist.</description></item>
        /// <item><description>offline_handled: handled offline.</description></item>
        /// <item><description>mark_mis_info: submits as a false positive.</description></item>
        /// <item><description>ignore: ignores the alert.</description></item>
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
        /// <para>The file source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>agentless: host detection.</description></item>
        /// <item><description>ecs_snapshot: user snapshot detection.</description></item>
        /// <item><description>ecs_image: user custom image detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRange { get; set; }

        /// <summary>
        /// <para>The batch processing scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>same_file_md5: same file MD5.</description></item>
        /// <item><description>default (default value): same alerting type.</description></item>
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
