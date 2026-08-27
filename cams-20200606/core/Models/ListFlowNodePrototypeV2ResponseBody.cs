// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListFlowNodePrototypeV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFlowNodePrototypeV2ResponseBodyData Data { get; set; }
        public class ListFlowNodePrototypeV2ResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of request result data.</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<ListFlowNodePrototypeV2ResponseBodyDataModel> Model { get; set; }
            public class ListFlowNodePrototypeV2ResponseBodyDataModel : TeaModel {
                /// <summary>
                /// <para>The component prototype code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SendWhatsAppMessageNode</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The component group code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Core</para>
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <para>The public extension information. This is used by the frontend to display extended information of flow components. The value is a JSON string. The first parameter in the string represents the flow component title. The following section describes the other fields:</para>
                /// <list type="bullet">
                /// <item><description><para>en: the English information of the flow component.</para>
                /// </description></item>
                /// <item><description><para>zh: the Chinese information of the flow component.</para>
                /// </description></item>
                /// <item><description><para>name: the name of the flow component.</para>
                /// </description></item>
                /// <item><description><para>remark: the remarks of the flow component.</para>
                /// </description></item>
                /// <item><description><para>order: the display order of the flow component.</para>
                /// </description></item>
                /// <item><description><para>style: the style of the flow component.</para>
                /// </description></item>
                /// <item><description><para>svg: the icon URL of the flow component.</para>
                /// </description></item>
                /// <item><description><para>icon: a deprecated field.</para>
                /// </description></item>
                /// <item><description><para>bgcolor: the background color of the icon.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;i18n\&quot;: {\&quot;en\&quot;: {\&quot;name\&quot;: \&quot;Send a WhatsApp Message\&quot;, \&quot;remark\&quot;: \&quot;Send a message with the ability for the user to reply utilizing WhatsApp specific features.\&quot;}, \&quot;zh\&quot;: {\&quot;name\&quot;: \&quot;Send WhatsApp messages\&quot;, \&quot;remark\&quot;: \&quot;Send a message that allows users to reply using specific features of WhatsApp\&quot;}}, \&quot;order\&quot;: \&quot;9000\&quot;, \&quot;style\&quot;: {\&quot;svg\&quot;: \&quot;<a href="https://img.alicdn.com/***********************************%5C%5C">https://img.alicdn.com/***********************************\\</a>&quot;, \&quot;icon\&quot;: \&quot;<a href="https://img.alicdn.com/***********************************%5C%5C">https://img.alicdn.com/***********************************\\</a>&quot;, \&quot;bgcolor\&quot;: \&quot;blue\&quot;}}</para>
                /// </summary>
                [NameInMap("PublicExtend")]
                [Validation(Required=false)]
                public string PublicExtend { get; set; }

                /// <summary>
                /// <para>The component prototype status. Default value: NORMAL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
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
