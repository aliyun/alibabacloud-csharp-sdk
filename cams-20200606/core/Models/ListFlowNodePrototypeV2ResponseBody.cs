// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListFlowNodePrototypeV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
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
            /// <para>A list of the returned data.</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<ListFlowNodePrototypeV2ResponseBodyDataModel> Model { get; set; }
            public class ListFlowNodePrototypeV2ResponseBodyDataModel : TeaModel {
                /// <summary>
                /// <para>The code of the component prototype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SendWhatsAppMessageNode</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The code of the component group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Core</para>
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <para>The public extension information. This is a JSON string that contains extension information for the frontend to display the flow component. The fields are described as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>en: The English information about the flow component.</para>
                /// </description></item>
                /// <item><description><para>zh: The Chinese information about the flow component.</para>
                /// </description></item>
                /// <item><description><para>name: The name of the flow component.</para>
                /// </description></item>
                /// <item><description><para>remark: The remarks on the flow component.</para>
                /// </description></item>
                /// <item><description><para>order: The display order of the flow component.</para>
                /// </description></item>
                /// <item><description><para>style: The style of the flow component.</para>
                /// </description></item>
                /// <item><description><para>svg: The URL of the flow component icon.</para>
                /// </description></item>
                /// <item><description><para>icon: This field is deprecated.</para>
                /// </description></item>
                /// <item><description><para>bgcolor: The background color of the icon.</para>
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
                /// <para>The status of the component prototype. The default value is NORMAL.</para>
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
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The call was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The call failed.</para>
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
