// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTransferInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTransferInfoResponseBodyData Data { get; set; }
        public class GetTransferInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creator.</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetTransferInfoResponseBodyDataCreator Creator { get; set; }
            public class GetTransferInfoResponseBodyDataCreator : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000001</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The approval flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753669315426</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public long? FlowId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1632036495973809</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1632036495973809</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The last modifier.</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public GetTransferInfoResponseBodyDataLastModifier LastModifier { get; set; }
            public class GetTransferInfoResponseBodyDataLastModifier : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000001</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The new owner.</para>
            /// </summary>
            [NameInMap("NewOwner")]
            [Validation(Required=false)]
            public GetTransferInfoResponseBodyDataNewOwner NewOwner { get; set; }
            public class GetTransferInfoResponseBodyDataNewOwner : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000001</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The previous owner.</para>
            /// </summary>
            [NameInMap("OldOwner")]
            [Validation(Required=false)]
            public GetTransferInfoResponseBodyDataOldOwner OldOwner { get; set; }
            public class GetTransferInfoResponseBodyDataOldOwner : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000001</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The transfer mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ONE_STOP: one-click transfer.</description></item>
            /// <item><description>FUNCTION_MODULE_BASED: transfer by function module.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONE_STOP</para>
            /// </summary>
            [NameInMap("PrivilegeTransferMode")]
            [Validation(Required=false)]
            public string PrivilegeTransferMode { get; set; }

            /// <summary>
            /// <para>The transfer details of function modules.</para>
            /// </summary>
            [NameInMap("PrivilegeTransferResultEntries")]
            [Validation(Required=false)]
            public List<GetTransferInfoResponseBodyDataPrivilegeTransferResultEntries> PrivilegeTransferResultEntries { get; set; }
            public class GetTransferInfoResponseBodyDataPrivilegeTransferResultEntries : TeaModel {
                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userId is error</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The name of the transfer module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table owner</para>
                /// </summary>
                [NameInMap("PrivilegeDisplayName")]
                [Validation(Required=false)]
                public string PrivilegeDisplayName { get; set; }

                /// <summary>
                /// <para>The status of the transfer module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The approval ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProposalId")]
            [Validation(Required=false)]
            public long? ProposalId { get; set; }

            /// <summary>
            /// <para>The approval title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>transefer title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The transfer description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("TransferComment")]
            [Validation(Required=false)]
            public string TransferComment { get; set; }

            /// <summary>
            /// <para>The transfer status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("TransferStatus")]
            [Validation(Required=false)]
            public string TransferStatus { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
