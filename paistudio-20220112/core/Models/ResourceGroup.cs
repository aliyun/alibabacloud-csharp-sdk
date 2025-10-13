// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceGroup : TeaModel {
        [NameInMap("CreatorID")]
        [Validation(Required=false)]
        public string CreatorID { get; set; }

        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RG1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg17tmvwiokhzaxg</para>
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23000</para>
        /// </summary>
        [NameInMap("WorkspaceID")]
        [Validation(Required=false)]
        public string WorkspaceID { get; set; }

    }

}
