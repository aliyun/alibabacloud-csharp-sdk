// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class SynchronizeResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource. This parameter is required only when you set the Type parameter to <c>ecs</c>. If you specify multiple IDs, separate them with commas (,). You can synchronize up to 50 resources at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp17c*<b>5q8x,i-bp1</b>5q8x</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The type of the resource to be synchronized. Valid values: <c>ecs, slb, vpc, and all</c>. These values are case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
