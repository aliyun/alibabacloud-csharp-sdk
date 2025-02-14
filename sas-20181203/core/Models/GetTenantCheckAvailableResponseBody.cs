// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetTenantCheckAvailableResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTenantCheckAvailableResponseBodyData Data { get; set; }
        public class GetTenantCheckAvailableResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp when you can submit a quick scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725530005357</para>
            /// </summary>
            [NameInMap("NextScanTime")]
            [Validation(Required=false)]
            public long? NextScanTime { get; set; }

            /// <summary>
            /// <para>The status of the quick scan task. Enumerated values:</para>
            /// <list type="bullet">
            /// <item><description>0: You can submit a quick scan task.</description></item>
            /// <item><description>1: The current task is not complete. You cannot submit a quick scan task.</description></item>
            /// <item><description>2: The free quota for this week is exhausted. You must wait for the next free scan period.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69BFFCDE-37D6-5A49-A8BC-BB03AC83****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
