// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyClusterOnlineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The cluster information.</para>
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<string> Clusters { get; set; }

        /// <summary>
        /// <para>The configuration information.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, int?> Config { get; set; }

    }

}
