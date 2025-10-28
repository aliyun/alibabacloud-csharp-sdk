// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the lane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>241</para>
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

    }

}
