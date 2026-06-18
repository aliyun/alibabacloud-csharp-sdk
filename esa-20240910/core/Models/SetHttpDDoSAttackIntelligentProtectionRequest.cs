// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetHttpDDoSAttackIntelligentProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The mode for the intelligent HTTP DDoS protection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>observe</b>: The system generates warnings for attack traffic but does not block it.</para>
        /// </description></item>
        /// <item><description><para><b>defense</b>: The system blocks detected attack traffic.</para>
        /// </description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>level60</para>
        /// </summary>
        [NameInMap("AiTemplate")]
        [Validation(Required=false)]
        public string AiTemplate { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can obtain the site ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
