// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud accounts.</para>
        /// </summary>
        [NameInMap("CloudAccounts")]
        [Validation(Required=false)]
        public List<ListCloudAccountsResponseBodyCloudAccounts> CloudAccounts { get; set; }
        public class ListCloudAccountsResponseBodyCloudAccounts : TeaModel {
            /// <summary>
            /// <para>The external unique identifier of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("CloudAccountExternalId")]
            [Validation(Required=false)]
            public string CloudAccountExternalId { get; set; }

            /// <summary>
            /// <para>The health status of the cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>healthy: healthy</description></item>
            /// <item><description>unhealthy: unhealthy</description></item>
            /// <item><description>unknown: unknown</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("CloudAccountHealth")]
            [Validation(Required=false)]
            public string CloudAccountHealth { get; set; }

            /// <summary>
            /// <para>The health check result of the cloud account.</para>
            /// </summary>
            [NameInMap("CloudAccountHealthCheckResult")]
            [Validation(Required=false)]
            public ListCloudAccountsResponseBodyCloudAccountsCloudAccountHealthCheckResult CloudAccountHealthCheckResult { get; set; }
            public class ListCloudAccountsResponseBodyCloudAccountsCloudAccountHealthCheckResult : TeaModel {
                /// <summary>
                /// <para>The error cause. This field is returned only when the health check status is unhealthy.</para>
                /// </summary>
                [NameInMap("ErrorReason")]
                [Validation(Required=false)]
                public ListCloudAccountsResponseBodyCloudAccountsCloudAccountHealthCheckResultErrorReason ErrorReason { get; set; }
                public class ListCloudAccountsResponseBodyCloudAccountsCloudAccountHealthCheckResultErrorReason : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AuthenticationFail.NoPermission</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There is no permission.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>The time of the last health check. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <para>The health check result of the cloud account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success: success</description></item>
                /// <item><description>failed: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The name of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_accout_xxxx</para>
            /// </summary>
            [NameInMap("CloudAccountName")]
            [Validation(Required=false)]
            public string CloudAccountName { get; set; }

            /// <summary>
            /// <para>The name of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas-eiam-oidc-provider</para>
            /// </summary>
            [NameInMap("CloudAccountProviderName")]
            [Validation(Required=false)]
            public string CloudAccountProviderName { get; set; }

            /// <summary>
            /// <para>The site of the cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>china_mainland: the Chinese mainland</description></item>
            /// <item><description>global: global</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>china_mainland</para>
            /// </summary>
            [NameInMap("CloudAccountSite")]
            [Validation(Required=false)]
            public string CloudAccountSite { get; set; }

            /// <summary>
            /// <para>The type of the cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>alibaba_cloud: Alibaba Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("CloudAccountVendorType")]
            [Validation(Required=false)]
            public string CloudAccountVendorType { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_accout_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The list of IDs of the associated privilege applications.</para>
            /// </summary>
            [NameInMap("PrivilegeApplicationIds")]
            [Validation(Required=false)]
            public List<string> PrivilegeApplicationIds { get; set; }

            /// <summary>
            /// <para>The cause of the privilege hosting or removal failure.</para>
            /// </summary>
            [NameInMap("PrivilegeHostingError")]
            [Validation(Required=false)]
            public ListCloudAccountsResponseBodyCloudAccountsPrivilegeHostingError PrivilegeHostingError { get; set; }
            public class ListCloudAccountsResponseBodyCloudAccountsPrivilegeHostingError : TeaModel {
                /// <summary>
                /// <para>The error code of the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message of the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test message</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>The hosting status of the cloud account. Default value: hosting_unmanaged. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>hosting_unmanaged: Unmanaged. The cloud account has not initiated hosting and is in the initial state.</description></item>
            /// <item><description>hosting_pending: Hosting. The hosting task has been submitted and is being executed asynchronously. Wait for the hosting process to complete before it enters the final state.</description></item>
            /// <item><description>hosting_completed: Hosting completed. The hosting process of the cloud account is executed successfully, and the relevant permission templates and hosting bindings have taken effect.</description></item>
            /// <item><description>hosting_failed: Hosting failed. The hosting process encounters an exception. You can view the cause of the failure and initiate hosting again.</description></item>
            /// <item><description>hosting_removing: Removing. The task to remove hosting has been submitted and is being executed asynchronously. Wait for the removal process to complete before it enters the final state.</description></item>
            /// <item><description>hosting_remove_failed: Removal failed. The removal process encounters an exception. You can view the cause of the failure and initiate removal again.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hosting_unmanaged</para>
            /// </summary>
            [NameInMap("PrivilegeHostingState")]
            [Validation(Required=false)]
            public string PrivilegeHostingState { get; set; }

            /// <summary>
            /// <para>The status of the privilege switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled. The resource is in effect and can be used normally.</description></item>
            /// <item><description>disabled: Disabled. The resource is deactivated and no longer takes effect. You can re-enable it to restore the resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PrivilegeStatus")]
            [Validation(Required=false)]
            public string PrivilegeStatus { get; set; }

            /// <summary>
            /// <para>The last update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page in paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token returned for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
