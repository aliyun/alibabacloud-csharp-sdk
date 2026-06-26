// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class GetAsrConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration level. Valid values: <c>0</c> (system), <c>1</c> (tenant), and <c>2</c> (instance).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfigLevel")]
        [Validation(Required=false)]
        public int? ConfigLevel { get; set; }

        /// <summary>
        /// <para>The ID of the entry at the level specified by <c>ConfigLevel</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

    }

}
