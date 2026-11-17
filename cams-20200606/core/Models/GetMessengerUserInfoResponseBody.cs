// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetMessengerUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OK: The request is successful.</para>
        /// </description></item>
        /// <item><description><para>Other error codes. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;: &quot;Test&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMessengerUserInfoResponseBodyData Data { get; set; }
        public class GetMessengerUserInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The personnel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample value</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample value</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The image URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;data&quot;:{&quot;is_silhouette&quot;:false,&quot;width&quot;:50,&quot;url&quot;:&quot;<a href="https://platform-lookaside.fbsbx.com/platform/profilepic/?eai=Aa4GrcPn_GreVmnksES-ikHy_fWLYbwACaaEnVMxMwYV0XtSBJqPtoqBUH4Z6RNXYEWVqqyuQ6_T&psid=25422133907435439&height=50&width=50&ext=1797389880&hash=Afugk9UPjVZkA-OkTjSoDlf-%22,%22height%22:50%7D%7D">https://platform-lookaside.fbsbx.com/platform/profilepic/?eai=Aa4GrcPn_GreVmnksES-ikHy_fWLYbwACaaEnVMxMwYV0XtSBJqPtoqBUH4Z6RNXYEWVqqyuQ6_T&amp;psid=25422133907435439&amp;height=50&amp;width=50&amp;ext=1797389880&amp;hash=Afugk9UPjVZkA-OkTjSoDlf-&quot;,&quot;height&quot;:50}}</a></para>
            /// </summary>
            [NameInMap("Picture")]
            [Validation(Required=false)]
            public Dictionary<string, object> Picture { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8831569-3D0E-5168-8E19-462ACF9DD568</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
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
