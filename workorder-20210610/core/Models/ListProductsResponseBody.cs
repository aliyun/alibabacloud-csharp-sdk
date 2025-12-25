// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code of the request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Return value, that is, product list</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyData> Data { get; set; }
        public class ListProductsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the product catalog, which represents the product category, such as elastic computing</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public long? DirectoryId { get; set; }

            /// <summary>
            /// <para>The name of the product catalog, which represents the product category, such as elastic computing</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("DirectoryName")]
            [Validation(Required=false)]
            public string DirectoryName { get; set; }

            /// <summary>
            /// <para>List of Alibaba Cloud products</para>
            /// </summary>
            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public List<ListProductsResponseBodyDataProductList> ProductList { get; set; }
            public class ListProductsResponseBodyDataProductList : TeaModel {
                /// <summary>
                /// <para>Alibaba Cloud product ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>7160</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public long? ProductId { get; set; }

                /// <summary>
                /// <para>Alibaba Cloud product name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message. If success is set to false, the message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the API request. The requestID is unique for each call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC0AB2EC-AFBC-44BA-AE77-132A5A1EC0AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates that the call is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
