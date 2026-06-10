// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetCreateLogoTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. The ErrorCode field is not returned if the request succeeds. If the request fails, the ErrorCode field is returned. For more information, see the error code list in this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliuid:1998006665794443 assumeRole not exist,serviceName:realtimelogpush.dcdnservices.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Job information</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetCreateLogoTaskResponseBodyTask Task { get; set; }
        public class GetCreateLogoTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>604860995</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The current status of the job:</para>
            /// <list type="bullet">
            /// <item><description>pending: Pending execution  </description></item>
            /// <item><description>configuring: Configuring  </description></item>
            /// <item><description>success: Succeeded  </description></item>
            /// <item><description>failed: Failed  </description></item>
            /// <item><description>partialFailed: Partially failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The URLs of the prefetched resources.</para>
            /// </summary>
            [NameInMap("Urls")]
            [Validation(Required=false)]
            public List<string> Urls { get; set; }

        }

    }

}
