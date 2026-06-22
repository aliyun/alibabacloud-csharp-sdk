// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetTenantCheckAvailableResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTenantCheckAvailableResponseBodyData Data { get; set; }
        public class GetTenantCheckAvailableResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp of the next time when a one-click scan can be submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725530005357</para>
            /// </summary>
            [NameInMap("NextScanTime")]
            [Validation(Required=false)]
            public long? NextScanTime { get; set; }

            /// <summary>
            /// <para>The current status of the one-click scan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: The one-click scan can be submitted.</para>
            /// </description></item>
            /// <item><description><para>1: The current task is not complete. The scan cannot be submitted.</para>
            /// </description></item>
            /// <item><description><para>2: The free scan quota for this week has been used. Wait until the next free scan time.</para>
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

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69BFFCDE-37D6-5A49-A8BC-BB03AC83****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
