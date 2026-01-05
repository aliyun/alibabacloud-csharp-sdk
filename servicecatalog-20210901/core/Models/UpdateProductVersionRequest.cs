// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateProductVersionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the product version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the product version. This is the default value.</description></item>
        /// <item><description>false: disables the product version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>The description of the product version.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the product version.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The recommendation information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Default: No recommendation information is provided. This is the default value.</description></item>
        /// <item><description>Recommended: the recommended version.</description></item>
        /// <item><description>Latest: the latest version.</description></item>
        /// <item><description>Deprecated: the version that is about to be discontinued.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Guidance")]
        [Validation(Required=false)]
        public string Guidance { get; set; }

        /// <summary>
        /// <para>The ID of the product version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv-bp15e79d26****</para>
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

        /// <summary>
        /// <para>The name of the product version.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("ProductVersionName")]
        [Validation(Required=false)]
        public string ProductVersionName { get; set; }

    }

}
