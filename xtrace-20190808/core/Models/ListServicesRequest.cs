// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the application. You can leave this parameter empty or set this parameter to <c>XTRACE</c>. We recommend that you leave this parameter empty.</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, applications monitored by Managed Service for OpenTelemetry or Application Real-Time Monitoring Service (ARMS) can be queried.</description></item>
        /// <item><description>If you set this parameter to <c>XTRACE</c>, only applications monitored by Managed Service for OpenTelemetry can be queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>XTRACE</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
