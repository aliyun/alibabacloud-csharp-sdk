// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetBackupAutoConfigStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBackupAutoConfigStatusResponseBodyData Data { get; set; }
        public class GetBackupAutoConfigStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the managed service supports configuring anti-ransomware backup policies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// <item><description><b>true</b>: Supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanConfigAuto")]
            [Validation(Required=false)]
            public bool? CanConfigAuto { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>898F7AA7-CECD-5EC7-AF4D-664C601B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
