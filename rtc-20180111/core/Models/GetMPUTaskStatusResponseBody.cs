// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class GetMPUTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>760bad53276431c499e30dc36f6b26be</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status ID of the bypass transcoding task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Waiting for the channel to start.</para>
        /// <remarks>
        /// <para>If the task is not started within 30 days, the task is automatically stopped.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>1</b>: The task is running.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: The task is stopped.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: The task is stopped by the user.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: The channel is stopped.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: Live streaming is stopped due to CDN network issues.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Live streaming is stopped due to live streaming URL issues.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
