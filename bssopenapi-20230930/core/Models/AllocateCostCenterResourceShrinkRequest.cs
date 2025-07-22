// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class AllocateCostCenterResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>637180</para>
        /// </summary>
        [NameInMap("FromCostCenterId")]
        [Validation(Required=false)]
        public long? FromCostCenterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1529600453335198</para>
        /// </summary>
        [NameInMap("FromOwnerAccountId")]
        [Validation(Required=false)]
        public long? FromOwnerAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceInstanceList")]
        [Validation(Required=false)]
        public string ResourceInstanceListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>638288</para>
        /// </summary>
        [NameInMap("ToCostCenterId")]
        [Validation(Required=false)]
        public long? ToCostCenterId { get; set; }

    }

}
