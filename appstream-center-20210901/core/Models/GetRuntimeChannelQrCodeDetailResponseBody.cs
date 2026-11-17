// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetRuntimeChannelQrCodeDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The QR code configuration details of the channel. If no QR code configuration process exists for the channel under the specified runtime, this field is empty.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuntimeChannelQrCodeDetailResponseBodyData Data { get; set; }
        public class GetRuntimeChannelQrCodeDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL or content of the QR code. If the QR code is not yet generated or the content is empty, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://qr.example.com/abc">https://qr.example.com/abc</a></para>
            /// </summary>
            [NameInMap("QrCode")]
            [Validation(Required=false)]
            public string QrCode { get; set; }

            /// <summary>
            /// <para>The access URL of the QR code configuration channel page. This URL is generated and sent to the user when the QR code configuration is initiated, and carries the taskId, channel code, and region parameters of the current process. If the URL is not recorded, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://eds.console.aliyun.com/public/scan-pair?taskId=8f14e45f-ceea-4672-9f6e-3c5b2a1d****&code=dingtalk-connector&region=cn-shanghai">https://eds.console.aliyun.com/public/scan-pair?taskId=8f14e45f-ceea-4672-9f6e-3c5b2a1d****&amp;code=dingtalk-connector&amp;region=cn-shanghai</a></para>
            /// </summary>
            [NameInMap("QrCodeNotifyUrl")]
            [Validation(Required=false)]
            public string QrCodeNotifyUrl { get; set; }

            /// <summary>
            /// <para>The scan status. Valid values: Generating (generating), Generated (generated), GenerateFailed (generation failed), Scanned (scanned), Configuring (configuring), Success (success), Failed (failed), and Expired (expired).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generated</para>
            /// </summary>
            [NameInMap("QrCodeStatus")]
            [Validation(Required=false)]
            public string QrCodeStatus { get; set; }

            /// <summary>
            /// <para>The status of the QR code configuration process. The valid values are the same as those of QrCodeStatus. Valid values: Generating (generating), Generated (generated), GenerateFailed (generation failed), Scanned (scanned), Configuring (configuring), Success (success), Failed (failed), and Expired (expired).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
