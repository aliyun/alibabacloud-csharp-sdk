// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListMseNacosSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMseNacosSourcesResponseBodyData Data { get; set; }
        public class ListMseNacosSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of Nacos instances that can be added.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListMseNacosSourcesResponseBodyDataItems> Items { get; set; }
            public class ListMseNacosSourcesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The Nacos instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse-cn-84a***</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The Nacos instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商品中心Nacos注册中心</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1994B10-C6A8-58FA-8347-6A08B0D4EFDE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
