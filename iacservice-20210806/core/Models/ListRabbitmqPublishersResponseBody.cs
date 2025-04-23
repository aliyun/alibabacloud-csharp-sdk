// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListRabbitmqPublishersResponseBody : TeaModel {
        [NameInMap("authorizations")]
        [Validation(Required=false)]
        public List<ListRabbitmqPublishersResponseBodyAuthorizations> Authorizations { get; set; }
        public class ListRabbitmqPublishersResponseBodyAuthorizations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-16T03:41:34Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exchangeName</para>
            /// </summary>
            [NameInMap("exchangeName")]
            [Validation(Required=false)]
            public string ExchangeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TOPIC</para>
            /// </summary>
            [NameInMap("exchangeType")]
            [Validation(Required=false)]
            public string ExchangeType { get; set; }

            [NameInMap("hostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MQ</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5671</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mqp-3b6cb9fa4751a6e5cd2682246</para>
            /// </summary>
            [NameInMap("publisherId")]
            [Validation(Required=false)]
            public string PublisherId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MjoxODgwNzcwODY5MD***</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>virtualHost</para>
            /// </summary>
            [NameInMap("virtualHost")]
            [Validation(Required=false)]
            public string VirtualHost { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6599600A-20F6-556D-A15C-55EB9243BB24</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
