// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAvailableHoneypotResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of images that are used for the honeypot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>An array consisting of the information about the images that are used for the honeypot.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAvailableHoneypotResponseBodyData> Data { get; set; }
        public class ListAvailableHoneypotResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The display name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RuoYi</para>
            /// </summary>
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:007095d6de9c7a343e9fc1f74a7efc9c5de9d5454789d2fa505a1b3fc62****</para>
            /// </summary>
            [NameInMap("HoneypotImageId")]
            [Validation(Required=false)]
            public string HoneypotImageId { get; set; }

            /// <summary>
            /// <para>The name of the image that is used for the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruoyi</para>
            /// </summary>
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            /// <summary>
            /// <para>The type of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Web</para>
            /// </summary>
            [NameInMap("HoneypotImageType")]
            [Validation(Required=false)]
            public string HoneypotImageType { get; set; }

            /// <summary>
            /// <para>The version of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.2</para>
            /// </summary>
            [NameInMap("HoneypotImageVersion")]
            [Validation(Required=false)]
            public string HoneypotImageVersion { get; set; }

            /// <summary>
            /// <para>The port that is supported by the honeypot. The value is in the JSON format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>log_type</b>: the log type</description></item>
            /// <item><description><b>proto</b>: the supported protocol</description></item>
            /// <item><description><b>description</b>: the description</description></item>
            /// <item><description><b>ports</b>: the supported ports</description></item>
            /// <item><description><b>port_str</b>: the supported port number of the string type</description></item>
            /// <item><description><b>type</b>: the type</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;log_type&quot;:&quot;web&quot;,&quot;proto&quot;:&quot;tcp&quot;,&quot;description&quot;:&quot;webServerPort&quot;,&quot;ports&quot;:[80.0],&quot;port_str&quot;:&quot;80&quot;,&quot;type&quot;:&quot;web&quot;}]</para>
            /// </summary>
            [NameInMap("Multiports")]
            [Validation(Required=false)]
            public string Multiports { get; set; }

            /// <summary>
            /// <para>The protocol that is supported by the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>The service port of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27017.0</para>
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public string ServicePort { get; set; }

            /// <summary>
            /// <para>The configuration template of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C24D883-984D-52FD-BB66-5F89F86E4837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
