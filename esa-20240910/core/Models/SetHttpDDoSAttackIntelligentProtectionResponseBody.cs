// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetHttpDDoSAttackIntelligentProtectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The protection mode for the intelligent HTTP DDoS protection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>observe</b>: The system generates warnings for attack traffic but does not block it.</para>
        /// </description></item>
        /// <item><description><para><b>defense</b>: The system blocks detected attack traffic.</para>
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
        /// <para>The sensitivity level for the intelligent HTTP DDoS protection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>level0</b>: very loose</para>
        /// </description></item>
        /// <item><description><para><b>level30</b>: loose</para>
        /// </description></item>
        /// <item><description><para><b>level60</b>: normal</para>
        /// </description></item>
        /// <item><description><para><b>level90</b>: strict</para>
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
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
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
