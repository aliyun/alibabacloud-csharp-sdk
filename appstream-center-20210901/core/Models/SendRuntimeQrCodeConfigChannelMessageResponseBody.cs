// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class SendRuntimeQrCodeConfigChannelMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of sending results for each runtime. Each runtime corresponds to one result. The return order is not guaranteed to be the same as the order of RuntimeIds in the request. Match the results by RuntimeId.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SendRuntimeQrCodeConfigChannelMessageResponseBodyData> Data { get; set; }
        public class SendRuntimeQrCodeConfigChannelMessageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code when the sending fails, such as Runtime.NotFound (the runtime does not exist) or Runtime.UserNotSupported (the runtime has no authorized users or has multiple authorized users). This parameter is not returned when the sending is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Runtime.UserNotSupported</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error message when the sending fails. This parameter is not returned when the sending is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Runtime has no authorized user</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The access URL of the QR code configuration channel page. It carries the taskId, channel code, and region parameters for the current process, and has been sent to the authorized user of the runtime by email and SMS. This parameter is returned only when the sending is successful. The taskId is valid for 1 hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://eds.console.aliyun.com/public/scan-pair?taskId=8f14e45f-ceea-4672-9f6e-3c5b2a1d****&code=feishu&region=cn-shanghai">https://eds.console.aliyun.com/public/scan-pair?taskId=8f14e45f-ceea-4672-9f6e-3c5b2a1d****&amp;code=feishu&amp;region=cn-shanghai</a></para>
            /// </summary>
            [NameInMap("QrCodeNotifyUrl")]
            [Validation(Required=false)]
            public string QrCodeNotifyUrl { get; set; }

            /// <summary>
            /// <para>The ID of the runtime resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-xgads</para>
            /// </summary>
            [NameInMap("RuntimeId")]
            [Validation(Required=false)]
            public string RuntimeId { get; set; }

            /// <summary>
            /// <para>Indicates whether the QR code configuration channel message for the runtime was initiated successfully. If the value is false, you can check the Code and Message fields for the cause of the failure.</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned sending results, which is the same as the number of results in Data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
