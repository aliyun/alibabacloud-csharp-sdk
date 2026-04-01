// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SyncRCKeyPairResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SyncRCKeyPairResponseBodyData Data { get; set; }
        public class SyncRCKeyPairResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the synchronization succeeded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSyncInfo")]
            [Validation(Required=false)]
            public bool? IsSyncInfo { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60478CCB-95EA-5D06-8A51-CAC83A316E9A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
