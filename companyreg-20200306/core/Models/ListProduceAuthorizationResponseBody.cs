// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class ListProduceAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListProduceAuthorizationResponseBodyData> Data { get; set; }
        public class ListProduceAuthorizationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12195411612139999</para>
            /// </summary>
            [NameInMap("AuthorizedUserId")]
            [Validation(Required=false)]
            public string AuthorizedUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test@alibaba-inc.com">test@alibaba-inc.com</a></para>
            /// </summary>
            [NameInMap("AuthorizedUserName")]
            [Validation(Required=false)]
            public string AuthorizedUserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10AAC56B-C512-5860-9A9E-B949431E7174</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>292</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
