// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAccountDeletionStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The deletion status of the member account.</para>
        /// </summary>
        [NameInMap("RdAccountDeletionStatus")]
        [Validation(Required=false)]
        public GetAccountDeletionStatusResponseBodyRdAccountDeletionStatus RdAccountDeletionStatus { get; set; }
        public class GetAccountDeletionStatusResponseBodyRdAccountDeletionStatus : TeaModel {
            /// <summary>
            /// <para>The ID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169946124551****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The time when the deletion started, in RFC 3339 format with a UTC offset of +08:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-23T17:05:30+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the deletion ended, in RFC 3339 format with a UTC offset of +08:00.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-23T17:06:01+08:00</para>
            /// </summary>
            [NameInMap("DeletionTime")]
            [Validation(Required=false)]
            public string DeletionTime { get; set; }

            /// <summary>
            /// <para>The deletion type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: direct deletion. If the member account has no pay-as-you-go resources in the last 30 days, the system directly deletes the member account.</description></item>
            /// <item><description>1: cool-down period deletion. If the member account has pay-as-you-go resources in the last 30 days, the member account enters a cool-down period. The system starts to delete the member account after the cool-down period ends. For more information about the cool-down period, see <a href="https://help.aliyun.com/document_detail/446079.html">What is the cool-down period for member account deletion</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeletionType")]
            [Validation(Required=false)]
            public string DeletionType { get; set; }

            /// <summary>
            /// <para>The reasons for the deletion failure.</para>
            /// </summary>
            [NameInMap("FailReasonList")]
            [Validation(Required=false)]
            public List<GetAccountDeletionStatusResponseBodyRdAccountDeletionStatusFailReasonList> FailReasonList { get; set; }
            public class GetAccountDeletionStatusResponseBodyRdAccountDeletionStatusFailReasonList : TeaModel {
                /// <summary>
                /// <para>The description of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This account has a payer account. Please release the financial relationship of this account first.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The service name of the cloud service to which the check item belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Others</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success: The member account is deleted.</description></item>
            /// <item><description>Checking: The check is in progress.</description></item>
            /// <item><description>Deleting: The deletion is in progress.</description></item>
            /// <item><description>CheckFailed: The check failed.</description></item>
            /// <item><description>DeleteFailed: The deletion failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AA43293-7C8F-5730-8F2D-7F864EC092C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
