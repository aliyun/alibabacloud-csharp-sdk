// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateComputeResourceAuthUserMappingsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The compute resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123455</para>
        /// </summary>
        [NameInMap("ComputeResourceId")]
        [Validation(Required=false)]
        public long? ComputeResourceId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The list of user mappings to remove.</para>
        /// </summary>
        [NameInMap("RemoveUserIds")]
        [Validation(Required=false)]
        public string RemoveUserIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of objects to update.</para>
        /// </summary>
        [NameInMap("Upserts")]
        [Validation(Required=false)]
        public string UpsertsShrink { get; set; }

    }

}
