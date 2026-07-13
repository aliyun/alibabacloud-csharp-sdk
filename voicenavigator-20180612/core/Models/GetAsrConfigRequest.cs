// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class GetAsrConfigRequest : TeaModel {
        /// <summary>
        /// <para>The policy level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: system</description></item>
        /// <item><description>1: tenant</description></item>
        /// <item><description>2: instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfigLevel")]
        [Validation(Required=false)]
        public int? ConfigLevel { get; set; }

        /// <summary>
        /// <para>The entity ID corresponding to config_level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

    }

}
