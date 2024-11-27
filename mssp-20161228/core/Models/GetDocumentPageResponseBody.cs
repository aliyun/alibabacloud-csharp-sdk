// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetDocumentPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDocumentPageResponseBodyData> Data { get; set; }
        public class GetDocumentPageResponseBodyData : TeaModel {
            [NameInMap("DeliveredBy")]
            [Validation(Required=false)]
            public string DeliveredBy { get; set; }

            [NameInMap("DocumentName")]
            [Validation(Required=false)]
            public string DocumentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DocumentType")]
            [Validation(Required=false)]
            public string DocumentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>346409</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-21 17:26:34</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetDocumentPageResponseBodyPageInfo PageInfo { get; set; }
        public class GetDocumentPageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04DAD7B4-E1DA-5C2C-8E5C-A1EDC880CF60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
