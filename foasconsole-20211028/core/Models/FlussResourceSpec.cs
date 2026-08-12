// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class FlussResourceSpec : TeaModel {
        /// <summary>
        /// <para>Disk size per node, in GB.</para>
        /// </summary>
        [NameInMap("DiskSizeInGB")]
        [Validation(Required=false)]
        public long? DiskSizeInGB { get; set; }

        /// <summary>
        /// <para>Instance type of the slave nodes.</para>
        /// </summary>
        [NameInMap("SlaveModel")]
        [Validation(Required=false)]
        public string SlaveModel { get; set; }

        /// <summary>
        /// <para>Number of slave nodes.</para>
        /// </summary>
        [NameInMap("SlaveNum")]
        [Validation(Required=false)]
        public long? SlaveNum { get; set; }

        /// <summary>
        /// <para>Number of CUs for the post-tiering stage.</para>
        /// </summary>
        [NameInMap("TieringPostCu")]
        [Validation(Required=false)]
        public long? TieringPostCu { get; set; }

        /// <summary>
        /// <para>Number of compute units (CUs) for the pre-tiering stage.</para>
        /// </summary>
        [NameInMap("TieringPreCu")]
        [Validation(Required=false)]
        public long? TieringPreCu { get; set; }

    }

}
