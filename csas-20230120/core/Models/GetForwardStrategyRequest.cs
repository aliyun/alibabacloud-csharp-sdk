// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetForwardStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The forwarding rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fs-651b975a22aa019c</para>
        /// </summary>
        [NameInMap("ForwardId")]
        [Validation(Required=false)]
        public string ForwardId { get; set; }

    }

}
