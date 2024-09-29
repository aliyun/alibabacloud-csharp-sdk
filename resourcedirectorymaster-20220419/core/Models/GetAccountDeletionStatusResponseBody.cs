// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetAccountDeletionStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The deletion status of the member.</para>
        /// </summary>
        [NameInMap("RdAccountDeletionStatus")]
        [Validation(Required=false)]
        public GetAccountDeletionStatusResponseBodyRdAccountDeletionStatus RdAccountDeletionStatus { get; set; }
        public class GetAccountDeletionStatusResponseBodyRdAccountDeletionStatus : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169946124551****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The start time of the deletion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-23T17:05:30+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The end time of the deletion.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-23T17:06:01+08:00</para>
            /// </summary>
            [NameInMap("DeletionTime")]
            [Validation(Required=false)]
            public string DeletionTime { get; set; }

            /// <summary>
            /// <para>The type of the deletion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: direct deletion. If the member does not have pay-as-you-go resources that are purchased within the previous 30 days, the system directly deletes the member.</description></item>
            /// <item><description>1: deletion with a silence period. If the member has pay-as-you-go resources that are purchased within the previous 30 days, the member enters a silence period of 45 days. The system starts to delete the member until the silence period ends. For more information about the silence period, see <a href="https://help.aliyun.com/document_detail/446079.html">What is the silence period for member deletion?</a></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeletionType")]
            [Validation(Required=false)]
            public string DeletionType { get; set; }

            /// <summary>
            /// <para>The reasons why the member fails to be deleted.</para>
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
                /// <para>The name of the cloud service to which the check item belongs.</para>
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
            /// <item><description>Success: The member is deleted.</description></item>
            /// <item><description>Checking: A deletion check is being performed for the member.</description></item>
            /// <item><description>Deleting: The member is being deleted.</description></item>
            /// <item><description>CheckFailed: The deletion check for the member fails.</description></item>
            /// <item><description>DeleteFailed: The member fails to be deleted.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AA43293-7C8F-5730-8F2D-7F864EC092C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
