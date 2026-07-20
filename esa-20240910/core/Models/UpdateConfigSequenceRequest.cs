// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateConfigSequenceRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID. You can call the <a href="~~ListSiteFunctions~~">ListSiteFunctions</a> operation to obtain the configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27490172680****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The target priority of the configuration. The value must be greater than 0. If the value is greater than the highest priority among all rule configurations under this feature, the priority of the configuration to be modified is set to the current highest priority. For example, if the CacheRules feature has three rule configurations with priorities 1, 2, and 3, and you change the priority of the rule with priority 1 to 5, the priority of that rule is set to 3, and the rules that originally had priorities 2 and 3 are changed to 1 and 2.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>611133661****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
