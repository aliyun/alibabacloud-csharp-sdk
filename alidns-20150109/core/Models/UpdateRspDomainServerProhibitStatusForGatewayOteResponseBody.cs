// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRspDomainServerProhibitStatusForGatewayOteResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed access-denied information. This field appears only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public UpdateRspDomainServerProhibitStatusForGatewayOteResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayOteResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UpdateRspDomainServerProhibitStatusForGatewayOte</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>Display name of the authenticated entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>Owner ID of the authenticated entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>Identity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>Encrypted diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQFohtp4aIbaeEXXXXQxNjFDLUIzMzgtNTXXXX05NkFCLUI2RkY5XXXXzAzQQ==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>Reason for authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ExplicitDeny</para>
            /// </description></item>
            /// <item><description><para>ImplicitDeny</para>
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
            /// <para>Policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>List of returned data items.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateRspDomainServerProhibitStatusForGatewayOteResponseBodyData Data { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayOteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Status information for the task</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<UpdateRspDomainServerProhibitStatusForGatewayOteResponseBodyDataStatusList> StatusList { get; set; }
            public class UpdateRspDomainServerProhibitStatusForGatewayOteResponseBodyDataStatusList : TeaModel {
                /// <summary>
                /// <para>Domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>Current domain name status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>serverUpdateProhibited</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Description of the domain name status.</para>
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
        /// <para>Indicates whether you can retry the request after failure. <c>true</c>: retry is allowed. <c>false</c>: retry is not allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RecoverableError")]
        [Validation(Required=false)]
        public bool? RecoverableError { get; set; }

        /// <summary>
        /// <para>Unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0629502C-6224-5DC9-A8ED-2ED73A2E3931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. <c>true</c>: succeeded. <c>false</c>: failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
