// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListHotlineTransferRegisterFileResponseBody : TeaModel {
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
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHotlineTransferRegisterFileResponseBodyData Data { get; set; }
        public class ListHotlineTransferRegisterFileResponseBodyData : TeaModel {
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
            /// <para>10</para>
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
            /// <para>The registration file.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ListHotlineTransferRegisterFileResponseBodyDataValues> Values { get; set; }
            public class ListHotlineTransferRegisterFileResponseBodyDataValues : TeaModel {
                /// <summary>
                /// <para>The authenticity of the commitment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Agree")]
                [Validation(Required=false)]
                public string Agree { get; set; }

                /// <summary>
                /// <para>The enterprise name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A**</para>
                /// </summary>
                [NameInMap("CorpName")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

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
                /// <para>The ID card number of the handler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5****************9</para>
                /// </summary>
                [NameInMap("MngOpIdentityCard")]
                [Validation(Required=false)]
                public string MngOpIdentityCard { get; set; }

                /// <summary>
                /// <para>The email address of the handler.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("MngOpMail")]
                [Validation(Required=false)]
                public string MngOpMail { get; set; }

                /// <summary>
                /// <para>The mobile phone number of the handler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150****0000</para>
                /// </summary>
                [NameInMap("MngOpMobile")]
                [Validation(Required=false)]
                public string MngOpMobile { get; set; }

                /// <summary>
                /// <para>The name of the handler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A***</para>
                /// </summary>
                [NameInMap("MngOpName")]
                [Validation(Required=false)]
                public string MngOpName { get; set; }

                /// <summary>
                /// <para>The qualification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234****</para>
                /// </summary>
                [NameInMap("QualificationId")]
                [Validation(Required=false)]
                public string QualificationId { get; set; }

                /// <summary>
                /// <para>The unique code of the query operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResUniqueCode")]
                [Validation(Required=false)]
                public long? ResUniqueCode { get; set; }

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
