// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRealtimeLogAuthorizedRequest : TeaModel {
        /// <summary>
        /// <para>This parameter has no practical significance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("LiveOpenapiReserve")]
        [Validation(Required=false)]
        public string LiveOpenapiReserve { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
