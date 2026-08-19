// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetDeviceOnlineHeatmapResponseBody : TeaModel {
        /// <summary>
        /// <para>The online time distribution.</para>
        /// </summary>
        [NameInMap("DeviceOnlineHeatmap")]
        [Validation(Required=false)]
        public List<List<long?>> DeviceOnlineHeatmap { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E850D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
