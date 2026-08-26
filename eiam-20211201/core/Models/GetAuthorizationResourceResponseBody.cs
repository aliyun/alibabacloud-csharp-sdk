// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetAuthorizationResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization resource.</para>
        /// </summary>
        [NameInMap("AuthorizationResource")]
        [Validation(Required=false)]
        public GetAuthorizationResourceResponseBodyAuthorizationResource AuthorizationResource { get; set; }
        public class GetAuthorizationResourceResponseBodyAuthorizationResource : TeaModel {
            /// <summary>
            /// <para>The resource entity ID associated with the authorization resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>carole_01kmek49aqxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationResourceEntityId")]
            [Validation(Required=false)]
            public string AuthorizationResourceEntityId { get; set; }

            /// <summary>
            /// <para>The resource entity type associated with the authorization resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_account_role: cloud role.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_account_role</para>
            /// </summary>
            [NameInMap("AuthorizationResourceEntityType")]
            [Validation(Required=false)]
            public string AuthorizationResourceEntityType { get; set; }

            /// <summary>
            /// <para>The authorization resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arres_01kgh3jvt7pk093rv6giu0c0qxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationResourceId")]
            [Validation(Required=false)]
            public string AuthorizationResourceId { get; set; }

            /// <summary>
            /// <para>The authorization rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arrule_01kf143ug06fg7m9f43u7vahxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationRuleId")]
            [Validation(Required=false)]
            public string AuthorizationRuleId { get; set; }

            /// <summary>
            /// <para>The cloud account ID to which the resource entity associated with the authorization resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The condition restriction.</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public GetAuthorizationResourceResponseBodyAuthorizationResourceCondition Condition { get; set; }
            public class GetAuthorizationResourceResponseBodyAuthorizationResourceCondition : TeaModel {
                /// <summary>
                /// <para>The credential condition.</para>
                /// </summary>
                [NameInMap("CredentialCondition")]
                [Validation(Required=false)]
                public GetAuthorizationResourceResponseBodyAuthorizationResourceConditionCredentialCondition CredentialCondition { get; set; }
                public class GetAuthorizationResourceResponseBodyAuthorizationResourceConditionCredentialCondition : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether same-name identity accounts are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AllowSameNameIdentity")]
                    [Validation(Required=false)]
                    public bool? AllowSameNameIdentity { get; set; }

                }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1787023451494</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1787023451494</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
