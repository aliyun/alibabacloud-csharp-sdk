// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateEmbeddedStatusRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable the embedding feature for the work. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables embedding.</description></item>
        /// <item><description>false: disables embedding.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ThirdPartAuthFlag")]
        [Validation(Required=false)]
        public bool? ThirdPartAuthFlag { get; set; }

        /// <summary>
        /// <para>The ID of the work.</para>
        /// <list type="bullet">
        /// <item><description>Batch modification is supported. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>897ce25e-f993-4abd-af84-d13c5610****</para>
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
