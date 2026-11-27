// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeStreamingOutStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>For abnormal tasks, RTC proactively ends the tasks and notifies the user server through callbacks. For more information, see <a href="https://help.aliyun.com/document_detail/2709168.html?spm=a2c4g.11186623.help-menu-61399.d_2_0_0_0.49be1761tge4EX#6211464494udk">Callbacks</a>.</para>
        /// <list type="bullet">
        /// <item><description>0: The task is started and waiting for users to join.</description></item>
        /// <item><description>1: Streaming in progress.</description></item>
        /// <item><description>2: Streaming exception, live streaming stopped.</description></item>
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
