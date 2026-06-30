// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryGroupLiveInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>333d</para>
        /// </summary>
        [NameInMap("AnchorUnionId")]
        [Validation(Required=false)]
        public string AnchorUnionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4d38xxxxx</para>
        /// </summary>
        [NameInMap("LiveUuid")]
        [Validation(Required=false)]
        public string LiveUuid { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
