// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the monitoring session.</para>
        /// <remarks>
        /// <para> You can obtain the monitoring session ID from the response parameter <b>MonitorId</b> of the <a href="https://help.aliyun.com/document_detail/2848129.html">CreateLiveStreamMonitor</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("MonitorId")]
        [Validation(Required=false)]
        public string MonitorId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
