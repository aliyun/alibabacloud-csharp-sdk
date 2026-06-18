// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeHttpDDoSAttackIntelligentProtectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The protection mode for HTTP DDoS intelligent protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>observe</b>: Observe</para>
        /// </description></item>
        /// <item><description><para><b>defense</b>: Defense</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("AiMode")]
        [Validation(Required=false)]
        public string AiMode { get; set; }

        /// <summary>
        /// <para>The protection level for HTTP DDoS intelligent protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>level0</b>: Very Loose</para>
        /// </description></item>
        /// <item><description><para><b>level30</b>: Loose</para>
        /// </description></item>
        /// <item><description><para><b>level60</b>: Normal</para>
        /// </description></item>
        /// <item><description><para><b>level90</b>: Strict</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>level60</para>
        /// </summary>
        [NameInMap("AiTemplate")]
        [Validation(Required=false)]
        public string AiTemplate { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-3C82-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
