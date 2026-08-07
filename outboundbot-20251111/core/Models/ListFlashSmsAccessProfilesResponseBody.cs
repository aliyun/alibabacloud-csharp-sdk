// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListFlashSmsAccessProfilesResponseBody : TeaModel {
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
        public ListFlashSmsAccessProfilesResponseBodyData Data { get; set; }
        public class ListFlashSmsAccessProfilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>数据列表</para>
            /// </summary>
            [NameInMap("FlashSmsAccessProfiles")]
            [Validation(Required=false)]
            public List<ListFlashSmsAccessProfilesResponseBodyDataFlashSmsAccessProfiles> FlashSmsAccessProfiles { get; set; }
            public class ListFlashSmsAccessProfilesResponseBodyDataFlashSmsAccessProfiles : TeaModel {
                /// <summary>
                /// <para>接入配置</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;apiId&quot;:&quot;100235&quot;,&quot;apiKey&quot;:&quot;3aRsPrTsDG3OPNq5&quot;,&quot;aesKey&quot;:&quot;TQChVEAabhaNp2AB&quot;,&quot;capAppId&quot;:&quot;300012117547&quot;}</para>
                /// </summary>
                [NameInMap("AccessProfile")]
                [Validation(Required=false)]
                public string AccessProfile { get; set; }

                /// <summary>
                /// <para>接入配置ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

                /// <summary>
                /// <para>创建时间，毫秒级时间戳</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

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

                /// <summary>
                /// <para>更新时间，毫秒级时间戳</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

            /// <summary>
            /// <para>页码，从1开始</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>每页记录数</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>符合条件的记录总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>Instance does not exist. Instance=outb001</para>
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
