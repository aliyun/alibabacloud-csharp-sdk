// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class GetAsrConfigRequest : TeaModel {
        /// <summary>
        /// <para>The policy level. Valid values: 0: system, 1: tenant, 2: instance.</para>
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
