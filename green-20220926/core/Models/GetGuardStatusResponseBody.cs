// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetGuardStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of log scan statistics.</para>
        /// </summary>
        [NameInMap("LogScanStatus")]
        [Validation(Required=false)]
        public List<GetGuardStatusResponseBodyLogScanStatus> LogScanStatus { get; set; }
        public class GetGuardStatusResponseBodyLogScanStatus : TeaModel {
            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Running.</description></item>
            /// <item><description>disabled: Not accessed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai_app_scan_bailian</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of protection status statistics.</para>
        /// </summary>
        [NameInMap("ProtectionStatus")]
        [Validation(Required=false)]
        public List<GetGuardStatusResponseBodyProtectionStatus> ProtectionStatus { get; set; }
        public class GetGuardStatusResponseBodyProtectionStatus : TeaModel {
            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Running.</description></item>
            /// <item><description>disabled: Not accessed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of real-time protection statistics.</para>
        /// </summary>
        [NameInMap("RealTimeStatus")]
        [Validation(Required=false)]
        public List<GetGuardStatusResponseBodyRealTimeStatus> RealTimeStatus { get; set; }
        public class GetGuardStatusResponseBodyRealTimeStatus : TeaModel {
            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Running.</description></item>
            /// <item><description>disabled: Not accessed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. This ID can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
