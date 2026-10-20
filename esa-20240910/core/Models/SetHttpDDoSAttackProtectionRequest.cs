// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetHttpDDoSAttackProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The mode of the HTTP DDoS Attack prevention mitigation policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>very weak</b>: Extremely loose.</description></item>
        /// <item><description><b>weak</b>: Loose.</description></item>
        /// <item><description><b>default</b>: Normal.</description></item>
        /// <item><description><b>hard</b>: Strict.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("GlobalMode")]
        [Validation(Required=false)]
        public string GlobalMode { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
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
