// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class PreviewOutputFileRequest : TeaModel {
        /// <summary>
        /// <para>The output item ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleOutputItemId</para>
        /// </summary>
        [NameInMap("outputItemId")]
        [Validation(Required=false)]
        public string OutputItemId { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The version referenced by the alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleVersionId</para>
        /// </summary>
        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
