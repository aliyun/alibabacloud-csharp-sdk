// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotPresetResponseBody : TeaModel {
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
        /// <para>The information about the honeypot template.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotPresetResponseBodyData Data { get; set; }
        public class GetHoneypotPresetResponseBodyData : TeaModel {
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
            /// <para>An array that consists of the configurations of the uploaded file.</para>
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetHoneypotPresetResponseBodyDataFileInfoList> FileInfoList { get; set; }
            public class GetHoneypotPresetResponseBodyDataFileInfoList : TeaModel {
                /// <summary>
                /// <para>The ID of the uploaded file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HONEYPOT_FILE/1765_167040128****</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>The name of the uploaded file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HONEYPOT_FILE****</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The download URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://aegis">http://aegis</a>****</para>
                /// </summary>
                [NameInMap("OssUrl")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

            }

            /// <summary>
            /// <para>The display name of the honeypot image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RuoYi</para>
            /// </summary>
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            /// <summary>
            /// <para>The name of the honeypot image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruoyi</para>
            /// </summary>
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            /// <summary>
            /// <para>The ID of the honeypot template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>94fd8805-d178-4361-84d3-de47fb4e****</para>
            /// </summary>
            [NameInMap("HoneypotPresetId")]
            [Validation(Required=false)]
            public string HoneypotPresetId { get; set; }

            /// <summary>
            /// <para>The custom configuration of the honeypot template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;trojan_git&quot;:&quot;zip&quot;,&quot;burp&quot;:&quot;open&quot;,&quot;portrait_option&quot;:&quot;true&quot;}</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

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
            /// <para>The custom name of the honeypot template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ssh</para>
            /// </summary>
            [NameInMap("PresetName")]
            [Validation(Required=false)]
            public string PresetName { get; set; }

            /// <summary>
            /// <para>The type of the honeypot template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TEMP</b>: automatically generated template</description></item>
            /// <item><description><b>CUSTOM</b>: custom template</description></item>
            /// <item><description><b>DEFAULT</b>: default template</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("PresetType")]
            [Validation(Required=false)]
            public string PresetType { get; set; }

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
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38AFE393-88E8-5642-B3E2-D57C6E76025D</para>
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
