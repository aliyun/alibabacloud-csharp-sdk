// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListFlashSmsProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>返回码</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回数据</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFlashSmsProvidersResponseBodyData> Data { get; set; }
        public class ListFlashSmsProvidersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>配置schema</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Pwd\&quot;:{\&quot;displayName\&quot;:\&quot;密码\&quot;,\&quot;dataType\&quot;:\&quot;TEXT\&quot;,\&quot;displayOrder\&quot;:2,\&quot;required\&quot;:true,\&quot;maxLength\&quot;:64},\&quot;User\&quot;:{\&quot;displayName\&quot;:\&quot;用户\&quot;,\&quot;dataType\&quot;:\&quot;TEXT\&quot;,\&quot;displayOrder\&quot;:1,\&quot;required\&quot;:true,\&quot;maxLength\&quot;:64},\&quot;Account\&quot;:{\&quot;displayName\&quot;:\&quot;账号\&quot;,\&quot;dataType\&quot;:\&quot;TEXT\&quot;,\&quot;displayOrder\&quot;:3,\&quot;required\&quot;:true,\&quot;maxLength\&quot;:64}}</para>
            /// </summary>
            [NameInMap("ProfileSchema")]
            [Validation(Required=false)]
            public string ProfileSchema { get; set; }

            /// <summary>
            /// <para>供应商ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>Uincall</para>
            /// </summary>
            [NameInMap("ProviderId")]
            [Validation(Required=false)]
            public string ProviderId { get; set; }

            /// <summary>
            /// <para>供应商名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京优音通信有限公司</para>
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

        }

        /// <summary>
        /// <para>HTTP状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>错误信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance does not exist. Instance=outb003</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>错误信息中的变量值列表</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>请求ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>是否调用成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
