// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMessageCallbackResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the event notification.</para>
        /// </summary>
        [NameInMap("MessageCallback")]
        [Validation(Required=false)]
        public GetMessageCallbackResponseBodyMessageCallback MessageCallback { get; set; }
        public class GetMessageCallbackResponseBodyMessageCallback : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-1000000</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The cryptographic key. This parameter is returned only for HTTP callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678abc</para>
            /// </summary>
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            /// <summary>
            /// <para>Indicates whether callback authentication is enabled. This parameter is returned only for HTTP callbacks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b></description></item>
            /// <item><description><b>off</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AuthSwitch")]
            [Validation(Required=false)]
            public string AuthSwitch { get; set; }

            /// <summary>
            /// <para>The callback method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b></description></item>
            /// <item><description><b>MNS</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("CallbackType")]
            [Validation(Required=false)]
            public string CallbackType { get; set; }

            /// <summary>
            /// <para>The callback URL. This parameter is returned only for HTTP callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://test.com/test">http://test.com/test</a></para>
            /// </summary>
            [NameInMap("CallbackURL")]
            [Validation(Required=false)]
            public string CallbackURL { get; set; }

            /// <summary>
            /// <para>The type of the callback event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FileUploadComplete,StreamTranscodeComplete,TranscodeComplete,SnapshotComplete,AIComplete,AddLiveRecordVideoComplete,CreateAuditComplete,UploadByURLComplete,ProduceMediaComplete,LiveRecordVideoComposeStart,ImageUploadComplete,VideoAnalysisComplete</para>
            /// </summary>
            [NameInMap("EventTypeList")]
            [Validation(Required=false)]
            public string EventTypeList { get; set; }

            /// <summary>
            /// <para>The public endpoint of MNS. This parameter is returned only for MNS callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://1234567.mns.cn-shanghai-internal.aliyuncs.com/">http://1234567.mns.cn-shanghai-internal.aliyuncs.com/</a></para>
            /// </summary>
            [NameInMap("MnsEndpoint")]
            [Validation(Required=false)]
            public string MnsEndpoint { get; set; }

            /// <summary>
            /// <para>The name of the Message Service (MNS) queue. This parameter is returned only for MNS callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vodcallback</para>
            /// </summary>
            [NameInMap("MnsQueueName")]
            [Validation(Required=false)]
            public string MnsQueueName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>272A222A-F7F7-4A3E-****-F531574F1234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
