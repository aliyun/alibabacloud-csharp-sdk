// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteDynamicRouteRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-ca9fddfac7c6****</para>
        /// </summary>
        [NameInMap("DynamicRouteId")]
        [Validation(Required=false)]
        public string DynamicRouteId { get; set; }

    }

}
