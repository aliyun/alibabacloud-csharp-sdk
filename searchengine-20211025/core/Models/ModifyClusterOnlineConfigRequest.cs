// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyClusterOnlineConfigRequest : TeaModel {
        /// <summary>
        /// The cluster information.
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<string> Clusters { get; set; }

        /// <summary>
        /// The configuration information.
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, int?> Config { get; set; }

    }

}
