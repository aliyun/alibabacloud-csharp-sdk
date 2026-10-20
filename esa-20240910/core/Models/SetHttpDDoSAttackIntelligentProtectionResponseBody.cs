// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetHttpDDoSAttackIntelligentProtectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP DDoS intelligent protection pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>observe</b>: Warning.</description></item>
        /// <item><description><b>defense</b>: Defense.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("AiMode")]
        [Validation(Required=false)]
        public string AiMode { get; set; }

        /// <summary>
        /// <para>The HTTP DDoS intelligent protection level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>level0</b>: Very loose.</description></item>
        /// <item><description><b>level30</b>: Loose.</description></item>
        /// <item><description><b>level60</b>: Normal.</description></item>
        /// <item><description><b>level90</b>: Strict.</description></item>
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
        /// <para>The ID of the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
