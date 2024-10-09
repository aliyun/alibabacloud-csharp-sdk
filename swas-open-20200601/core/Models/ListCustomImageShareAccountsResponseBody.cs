// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListCustomImageShareAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the shared custom images.</para>
        /// </summary>
        [NameInMap("ImageShareUsers")]
        [Validation(Required=false)]
        public List<ListCustomImageShareAccountsResponseBodyImageShareUsers> ImageShareUsers { get; set; }
        public class ListCustomImageShareAccountsResponseBodyImageShareUsers : TeaModel {
            /// <summary>
            /// <para>The time when the custom image is shared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-15 13:59:21.0</para>
            /// </summary>
            [NameInMap("SharedTime")]
            [Validation(Required=false)]
            public string SharedTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account whose custom image is shared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>125111425233****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
