// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class RollbackAppCodeSnapshotRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1067072706415168</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1231</para>
        /// </summary>
        [NameInMap("TargetLogicalNumber")]
        [Validation(Required=false)]
        public int? TargetLogicalNumber { get; set; }

    }

}
