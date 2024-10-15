// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListHotlineTransferNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/112502.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the registered phone number.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHotlineTransferNumberResponseBodyData Data { get; set; }
        public class ListHotlineTransferNumberResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>The phone numbers.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ListHotlineTransferNumberResponseBodyDataValues> Values { get; set; }
            public class ListHotlineTransferNumberResponseBodyDataValues : TeaModel {
                /// <summary>
                /// <para>The China 400 number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400****</para>
                /// </summary>
                [NameInMap("HotlineNumber")]
                [Validation(Required=false)]
                public string HotlineNumber { get; set; }

                /// <summary>
                /// <para>The ID card number of the number owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500***4119</para>
                /// </summary>
                [NameInMap("IdentityCard")]
                [Validation(Required=false)]
                public string IdentityCard { get; set; }

                /// <summary>
                /// <para>The real name of the number owner or the company name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A***</para>
                /// </summary>
                [NameInMap("NumberOwnerName")]
                [Validation(Required=false)]
                public string NumberOwnerName { get; set; }

                /// <summary>
                /// <para>The registered phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1580000****</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>The qualification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100***</para>
                /// </summary>
                [NameInMap("QualificationId")]
                [Validation(Required=false)]
                public string QualificationId { get; set; }

                /// <summary>
                /// <para>The resource code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1***</para>
                /// </summary>
                [NameInMap("ResUniqueCode")]
                [Validation(Required=false)]
                public string ResUniqueCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6086693B-2250-17CE-A41F-06259AB6DB1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
