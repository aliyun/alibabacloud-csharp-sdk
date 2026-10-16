// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAccountDeletionCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the member deletion check.</para>
        /// </summary>
        [NameInMap("AccountDeletionCheckResultInfo")]
        [Validation(Required=false)]
        public GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfo AccountDeletionCheckResultInfo { get; set; }
        public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfo : TeaModel {
            /// <summary>
            /// <para>The check items that you can choose to abandon and proceed with the member deletion.</para>
            /// <remarks>
            /// <para>This parameter may be returned when AllowDelete is set to true.</para>
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
                /// <para>The service name of the cloud service to which the check item belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Container Service</para>
                /// </summary>
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// <para>The description of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud service instances are running. Submit a ticket to contact customer service for assistance</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the member account can be deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The member account can be deleted.</description></item>
            /// <item><description>false: The member account cannot be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowDelete")]
            [Validation(Required=false)]
            public string AllowDelete { get; set; }

            /// <summary>
            /// <para>The reasons why the member account cannot be deleted.</para>
            /// <remarks>
            /// <para>This parameter is returned only when AllowDelete is set to false.</para>
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
                /// <para>The service name of the cloud service to which the check item belongs.</para>
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
            /// <para>The check status. Valid values:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54AC391D-4F7F-5F08-B8D3-0AECDE6EC5BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
