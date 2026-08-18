// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class CreateVirusScanOnceTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call fails. For more information, refer to error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateVirusScanOnceTaskResponseBodyData Data { get; set; }
        public class CreateVirusScanOnceTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asset selection business type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VIRUS_SCAN_CYCLE_CONFIG</b>: virus scan configuration</description></item>
            /// <item><description><b>VIRUS_SCAN_ONCE_TASK</b>: virus scan one-time task</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VIRUS_SCAN_CYCLE_CONFIG</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The operating system of the target asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b>: Windows operating system</description></item>
            /// <item><description><b>linux</b>: Linux operating system</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1D345A09-5ABD-593C-9C26-5C2B28632CD6</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The unique identifier of this asset selection, which can be used to query or modify the assets corresponding to this selection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87af4d19-38fc-408d-9549-2bf7b6c2a4b9</para>
            /// </summary>
            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public int? SelectionKey { get; set; }

            /// <summary>
            /// <para>The target asset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>all_instance</b>: all servers</description></item>
            /// <item><description><b>instance</b>: select by server</description></item>
            /// <item><description><b>group</b>: select by group</description></item>
            /// <item><description><b>vpc</b>: select by VPC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all_instance</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The server ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9ef1a02e1de695cb7f9fea2c6c145853eklEsP2JP0Z</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The message information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>739705BB-B0EF-554B-B3A8-383F4F93E067</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.                               </description></item>
        /// <item><description><b>false</b>: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
