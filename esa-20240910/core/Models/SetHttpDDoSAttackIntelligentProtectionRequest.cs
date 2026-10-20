// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetHttpDDoSAttackIntelligentProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The HTTP DDoS depth learning and defense pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>observe</b>: Monitor.</description></item>
        /// <item><description><b>defense</b>: Block.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("AiMode")]
        [Validation(Required=false)]
        public string AiMode { get; set; }

        /// <summary>
        /// <para>The HTTP DDoS deep learning and protection level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>level0</b>: Very loose.</description></item>
        /// <item><description><b>level30</b>: Loose.</description></item>
        /// <item><description><b>level60</b>: Normal.</description></item>
        /// <item><description><b>level90</b>: Strict.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>level60</para>
        /// </summary>
        [NameInMap("AiTemplate")]
        [Validation(Required=false)]
        public string AiTemplate { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
