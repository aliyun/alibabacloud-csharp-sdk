// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessEndpointAvailableZonesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region supported by dedicated network endpoints.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("NaeRegionId")]
        [Validation(Required=false)]
        public string NaeRegionId { get; set; }

    }

}
