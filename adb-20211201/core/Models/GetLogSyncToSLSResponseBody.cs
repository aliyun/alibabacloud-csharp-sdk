// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetLogSyncToSLSResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLogSyncToSLSResponseBodyData Data { get; set; }
        public class GetLogSyncToSLSResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The log synchronization status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Synchronization is enabled.</description></item>
            /// <item><description>off: Synchronization is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The Simple Log Service Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbmysql-audit-log</para>
            /// </summary>
            [NameInMap("TargetLogStore")]
            [Validation(Required=false)]
            public string TargetLogStore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log-service-****-cn-shenzhen</para>
            /// </summary>
            [NameInMap("TargetProject")]
            [Validation(Required=false)]
            public string TargetProject { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
