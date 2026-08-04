// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubscriptionAlbumCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Additional information</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>60E7A523-9766-1D07-87A2-6E587420C59B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of categories</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListSubscriptionAlbumCategoryResponseBodyResult> Result { get; set; }
        public class ListSubscriptionAlbumCategoryResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Category ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>80011</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>Category name</para>
            /// 
            /// <b>Example:</b>
            /// <para>儿童</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

        }

    }

}
