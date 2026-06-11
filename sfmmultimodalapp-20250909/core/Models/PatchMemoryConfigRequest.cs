// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class PatchMemoryConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AutoUpdate")]
        [Validation(Required=false)]
        public bool? AutoUpdate { get; set; }

        [NameInMap("ExpirationTime")]
        [Validation(Required=false)]
        public int? ExpirationTime { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        [NameInMap("UserDefinedId")]
        [Validation(Required=false)]
        public string UserDefinedId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
