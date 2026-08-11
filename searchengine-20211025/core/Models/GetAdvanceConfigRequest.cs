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
        /// <item><description><para>The type of the advanced configuration. Valid values: -ONLINE: online configuration</para>
        /// </description></item>
        /// <item><description><para>-ONLINE_CAVA: online Cava configuration</para>
        /// </description></item>
        /// <item><description><para>-ONLINE_PLUGIN: online plug-in configuration</para>
        /// </description></item>
        /// <item><description><para>-ONLINE_QUERY: query configuration</para>
        /// </description></item>
        /// <item><description><para>-OFFLINE_DICT: offline dictionary configuration</para>
        /// </description></item>
        /// <item><description><para>-OFFLINE_TABLE: offline table configuration</para>
        /// </description></item>
        /// <item><description><para>-OFFLINE_COMMON: offline configuration</para>
        /// </description></item>
        /// <item><description><para>-OFFLINE_PLUGIN: offline plug-in configuration</para>
        /// </description></item>
        /// <item><description><para>-OFFLINE_INDEX: index configuration</para>
        /// </description></item>
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
