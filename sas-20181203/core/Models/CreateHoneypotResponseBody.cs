// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotResponseBody : TeaModel {
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
        /// <para>The information about the honeypot.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateHoneypotResponseBodyData Data { get; set; }
        public class CreateHoneypotResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>managerNodename</para>
            /// </summary>
            [NameInMap("ControlNodeName")]
            [Validation(Required=false)]
            public string ControlNodeName { get; set; }

            /// <summary>
            /// <para>The ID of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9bf8cd373112263d4bc102fc5dba9d9f812ee05d4d35c487d330d52e937f****</para>
            /// </summary>
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

            /// <summary>
            /// <para>The display name of the honeypot image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HoneyDisplayName</para>
            /// </summary>
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            /// <summary>
            /// <para>The name of the honeypot image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp_proxy</para>
            /// </summary>
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            /// <summary>
            /// <para>The custom name of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruoyi</para>
            /// </summary>
            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            /// <summary>
            /// <para>The ID of the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a882e590-b87b-45a6-87b9-d0a3e5a0****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The ID of the custom configuration for the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddh3731641137fe4b72b245346a2721d4b6tdgg3731641137fe4b72b245346a2721***</para>
            /// </summary>
            [NameInMap("PresetId")]
            [Validation(Required=false)]
            public string PresetId { get; set; }

            /// <summary>
            /// <para>An array that consists of the status information about the honeypot.</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public List<string> State { get; set; }

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
        /// <para>29874225-EAAC-5415-8501-32DD20FD29F6</para>
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
