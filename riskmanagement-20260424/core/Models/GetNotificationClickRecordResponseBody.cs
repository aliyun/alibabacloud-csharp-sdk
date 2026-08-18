// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetNotificationClickRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: Succeeded.</description></item>
        /// <item><description><b>Others (400, 500)</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNotificationClickRecordResponseBodyData Data { get; set; }
        public class GetNotificationClickRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user clicked cancel.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Canceled.</description></item>
            /// <item><description><b>false</b>: Not canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UserCancel")]
            [Validation(Required=false)]
            public string UserCancel { get; set; }

            /// <summary>
            /// <para>Indicates whether the user clicked confirm.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Confirmed.</description></item>
            /// <item><description><b>false</b>: Not confirmed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UserConfirm")]
            [Validation(Required=false)]
            public string UserConfirm { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request was successful, a success message is returned. If the request failed, the failure reason is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99D93ED4-D462-5FC5-8518-9BC1C49C7B6C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.         </description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
