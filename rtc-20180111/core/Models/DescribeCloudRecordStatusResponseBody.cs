// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCloudRecordStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>0: The task has started and is waiting for users to join.</description></item>
        /// <item><description>100: The task has not started.</description></item>
        /// <item><description>101: Recording is in progress.</description></item>
        /// <item><description>102: The recording file is being uploaded.</description></item>
        /// <item><description>200: Recording is completed (channel ended).</description></item>
        /// <item><description>201: Recording is completed (stopped by user).</description></item>
        /// <item><description>400: Recording failed (internal server error).</description></item>
        /// <item><description>401: Recording failed (failed to write to user storage).</description></item>
        /// <item><description>402: Recording failed (failed to start user storage).</description></item>
        /// <item><description>403: Recording failed (recording duration too short).</description></item>
        /// <item><description>404: Recording failed (incorrect user storage key).</description></item>
        /// <item><description>405: Recording failed (bucket does not exist).</description></item>
        /// <item><description>406: Recording failed (access to user storage denied).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
