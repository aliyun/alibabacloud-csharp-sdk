// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOrderBaseInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The basic information about the ticket.</para>
        /// </summary>
        [NameInMap("OrderBaseInfo")]
        [Validation(Required=false)]
        public GetOrderBaseInfoResponseBodyOrderBaseInfo OrderBaseInfo { get; set; }
        public class GetOrderBaseInfoResponseBodyOrderBaseInfo : TeaModel {
            /// <summary>
            /// <para>The Key of the ticket attachment. This information is returned only when an attachment is uploaded when a ticket is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload_order_info_856887_f356366f-f0f8-42fc-ba57-4a509303e814_18072d8a9bce876e3073bc655c2865f.png</para>
            /// </summary>
            [NameInMap("AttachmentKey")]
            [Validation(Required=false)]
            public string AttachmentKey { get; set; }

            /// <summary>
            /// <para>The remarks of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The applicant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }

            /// <summary>
            /// <para>The ID of the applicant. Note: The ID is different from the Alibaba Cloud account ID of the applicant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public long? CommitterId { get; set; }

            /// <summary>
            /// <para>The time when the ticket was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-10 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the ticket was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-10 00:00:00</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The original file name of the ticket attachment. This information is returned only when an attachment is uploaded when a ticket is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18072d8a9bce876e3073bc655c2865f.png</para>
            /// </summary>
            [NameInMap("OriginAttachmentName")]
            [Validation(Required=false)]
            public string OriginAttachmentName { get; set; }

            /// <summary>
            /// <para>The type of the ticket. For more information about the value of this parameter, see the request parameters of the <a href="https://help.aliyun.com/document_detail/465865.html">CreateOrder</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DC_COMMON</para>
            /// </summary>
            [NameInMap("PluginType")]
            [Validation(Required=false)]
            public string PluginType { get; set; }

            /// <summary>
            /// <para>The IDs of the operators that are related to the ticket.</para>
            /// </summary>
            [NameInMap("RelatedUserList")]
            [Validation(Required=false)]
            public GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserList RelatedUserList { get; set; }
            public class GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserList : TeaModel {
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

            /// <summary>
            /// <para>The nicknames of the operators that are related to the ticket.</para>
            /// </summary>
            [NameInMap("RelatedUserNickList")]
            [Validation(Required=false)]
            public GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserNickList RelatedUserNickList { get; set; }
            public class GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserNickList : TeaModel {
                [NameInMap("UserNicks")]
                [Validation(Required=false)]
                public List<string> UserNicks { get; set; }

            }

            /// <summary>
            /// <para>The status code of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>new</b>: The ticket is created.</description></item>
            /// <item><description><b>toaudit</b>: The ticket is being reviewed.</description></item>
            /// <item><description><b>Approved</b>: The ticket is approved.</description></item>
            /// <item><description><b>reject</b>: The ticket is rejected.</description></item>
            /// <item><description><b>processing</b>: The ticket is being executed.</description></item>
            /// <item><description><b>success</b>: The ticket is executed.</description></item>
            /// <item><description><b>closed</b>: The ticket is closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The description of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The ID of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

            /// <summary>
            /// <para>The description of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approved</para>
            /// </summary>
            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7133DF67-5B25-460F-8285-C4CC93472C2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
