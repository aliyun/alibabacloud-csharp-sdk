// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class WorkspaceSpecs : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DLC</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("Specs")]
        [Validation(Required=false)]
        public List<WorkspaceSpec> Specs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>122421</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
