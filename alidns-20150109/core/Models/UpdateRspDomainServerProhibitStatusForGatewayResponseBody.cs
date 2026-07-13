// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRspDomainServerProhibitStatusForGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This field is returned only when Resource Access Management (RAM) authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public UpdateRspDomainServerProhibitStatusForGatewayResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UpdateRspDomainServerProhibitStatusForGateway</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authorized entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the owner of the authorized entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The identity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encrypted complete diagnostic information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQFohtp4aIbaeEXXXXQxNjFDLUIzMzgtNTXXXX05NkFCLUI2RkY5XXXXzAzQQ==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason why authentication failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ExplicitDeny: The access is explicitly denied.</para>
            /// </description></item>
            /// <item><description><para>ImplicitDeny: The access is implicitly denied.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateRspDomainServerProhibitStatusForGatewayResponseBodyData Data { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The status information of the task.</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<UpdateRspDomainServerProhibitStatusForGatewayResponseBodyDataStatusList> StatusList { get; set; }
            public class UpdateRspDomainServerProhibitStatusForGatewayResponseBodyDataStatusList : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>uptp.test.abchina.com.cn</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The current status of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>serverUpdateProhibited</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The message for the domain name status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>实名认证未通过，增加serverUpdateProhibited状态</para>
                /// </summary>
                [NameInMap("StatusMsg")]
                [Validation(Required=false)]
                public string StatusMsg { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request can be retried if it fails. true: The request can be retried. false: The request cannot be retried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RecoverableError")]
        [Validation(Required=false)]
        public bool? RecoverableError { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0629502C-6224-5DC9-A8ED-2ED73A2E3931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. true: The request was successful. false: The request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
