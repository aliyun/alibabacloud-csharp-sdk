// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListTicketOperateRecordResponseBody : TeaModel {
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ListTicketOperateRecordResponseBodyRecords> Records { get; set; }
        public class ListTicketOperateRecordResponseBodyRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>a8iSxxxxgtgiE</para>
            /// </summary>
            [NameInMap("OpenTicketId")]
            [Validation(Required=false)]
            public string OpenTicketId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;originTakers&quot;:[{&quot;nickName&quot;:&quot;贤文&quot;,&quot;unionId&quot;:&quot;Dq9hxxxxwiEiE&quot;},{&quot;nickName&quot;:&quot;王鸿程&quot;,&quot;unionId&quot;:&quot;4kITooxxxx5wiEiE&quot;}]}</para>
            /// </summary>
            [NameInMap("OperateData")]
            [Validation(Required=false)]
            public string OperateData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-07-09 19:26:09</para>
            /// </summary>
            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public string OperateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>结单</para>
            /// </summary>
            [NameInMap("OperationDisplayName")]
            [Validation(Required=false)]
            public string OperationDisplayName { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public ListTicketOperateRecordResponseBodyRecordsOperator Operator { get; set; }
            public class ListTicketOperateRecordResponseBodyRecordsOperator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>贤文</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("UnionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            [NameInMap("TicketMemo")]
            [Validation(Required=false)]
            public ListTicketOperateRecordResponseBodyRecordsTicketMemo TicketMemo { get; set; }
            public class ListTicketOperateRecordResponseBodyRecordsTicketMemo : TeaModel {
                [NameInMap("Attachments")]
                [Validation(Required=false)]
                public List<ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments> Attachments { get; set; }
                public class ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>wahaha.txt</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ticket/image/447xxxx9/43003/e2xxxec4243e940a1367_1625xxxx99.txt</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>贤文结束工单</para>
                /// </summary>
                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
