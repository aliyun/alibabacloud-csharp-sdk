// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetAccountDeletionCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the deletion check for the member.</para>
        /// </summary>
        [NameInMap("AccountDeletionCheckResultInfo")]
        [Validation(Required=false)]
        public GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfo AccountDeletionCheckResultInfo { get; set; }
        public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfo : TeaModel {
            /// <summary>
            /// <para>The check items that you can choose to ignore for the member deletion.</para>
            /// <remarks>
            /// <para>This parameter may be returned if the value of AllowDelete is true.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AbandonableChecks")]
            [Validation(Required=false)]
            public List<GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoAbandonableChecks> AbandonableChecks { get; set; }
            public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoAbandonableChecks : TeaModel {
                /// <summary>
                /// <para>The ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NON_SP_cs</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                /// <summary>
                /// <para>The name of the cloud service to which the check item belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Container Service for Kubernetes</para>
                /// </summary>
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// <para>The description of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An instance of a cloud service is running within the member. Submit a ticket to contact Alibaba Cloud technical support.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the member can be deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The member can be deleted.</description></item>
            /// <item><description>false: The member cannot be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowDelete")]
            [Validation(Required=false)]
            public string AllowDelete { get; set; }

            /// <summary>
            /// <para>The reasons why the member cannot be deleted.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the value of AllowDelete is false.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NotAllowReason")]
            [Validation(Required=false)]
            public List<GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoNotAllowReason> NotAllowReason { get; set; }
            public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoNotAllowReason : TeaModel {
                /// <summary>
                /// <para>The ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NON_SP_efc</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                /// <summary>
                /// <para>The name of the cloud service to which the check item belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise finance</para>
                /// </summary>
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// <para>The description of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This account is an Enterprise Finance associated account. Please remove the financial association of this account before deleting it.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The status of the check. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PreCheckComplete: The check is complete.</description></item>
            /// <item><description>PreChecking: The check is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PreCheckComplete</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54AC391D-4F7F-5F08-B8D3-0AECDE6EC5BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
