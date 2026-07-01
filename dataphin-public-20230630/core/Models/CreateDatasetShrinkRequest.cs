// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDatasetShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The creation request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public string CreateCommandShrink { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7255013756724992</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
