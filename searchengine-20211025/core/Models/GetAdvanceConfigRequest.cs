// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetAdvanceConfigRequest : TeaModel {
        /// <summary>
        /// *   The type of the advanced configuration. Valid values: -ONLINE: online configuration
        /// *   \\-ONLINE_CAVA: online Cava configuration
        /// *   \\-ONLINE_PLUGIN: online plug-in configuration
        /// *   \\-ONLINE_QUERY: query configuration
        /// *   \\-OFFLINE_DICT: offline dictionary configuration
        /// *   \\-OFFLINE_TABLE: offline table configuration
        /// *   \\-OFFLINE_COMMON: offline configuration
        /// *   \\-OFFLINE_PLUGIN: offline plug-in configuration
        /// *   \\-OFFLINE_INDEX: index configuration
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
