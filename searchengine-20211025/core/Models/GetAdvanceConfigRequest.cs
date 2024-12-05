// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetAdvanceConfigRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The type of the advanced configuration. Valid values: -ONLINE: online configuration</description></item>
        /// <item><description>\-ONLINE_CAVA: online Cava configuration</description></item>
        /// <item><description>\-ONLINE_PLUGIN: online plug-in configuration</description></item>
        /// <item><description>\-ONLINE_QUERY: query configuration</description></item>
        /// <item><description>\-OFFLINE_DICT: offline dictionary configuration</description></item>
        /// <item><description>\-OFFLINE_TABLE: offline table configuration</description></item>
        /// <item><description>\-OFFLINE_COMMON: offline configuration</description></item>
        /// <item><description>\-OFFLINE_PLUGIN: offline plug-in configuration</description></item>
        /// <item><description>\-OFFLINE_INDEX: index configuration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ONLINE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
