// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class QueryFaceRecordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<QueryFaceRecordResponseBodyItems> Items { get; set; }
        public class QueryFaceRecordResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>230642938</para>
            /// </summary>
            [NameInMap("FaceId")]
            [Validation(Required=false)]
            public string FaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-15T02:20:28Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16112</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.xxxx.com/1.jpg">http://www.xxxx.com/1.jpg</a></para>
            /// </summary>
            [NameInMap("ImgOssUrl")]
            [Validation(Required=false)]
            public string ImgOssUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CuN6hiD08qr</para>
            /// </summary>
            [NameInMap("MerchantUserId")]
            [Validation(Required=false)]
            public string MerchantUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MANUAL</para>
            /// </summary>
            [NameInMap("RegistrationType")]
            [Validation(Required=false)]
            public string RegistrationType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAARfZmVDe9NvRXloR5+8CK9nwqHyx44CQz3pa71+mmu0e</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F971622-38C0-5F56-B2EC-315367979B4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
