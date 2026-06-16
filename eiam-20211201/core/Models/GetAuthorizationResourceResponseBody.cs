// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetAuthorizationResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorized resource.</para>
        /// </summary>
        [NameInMap("AuthorizationResource")]
        [Validation(Required=false)]
        public GetAuthorizationResourceResponseBodyAuthorizationResource AuthorizationResource { get; set; }
        public class GetAuthorizationResourceResponseBodyAuthorizationResource : TeaModel {
            /// <summary>
            /// <para>The ID of the resource entity that is associated with the authorized resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>carole_01kmek49aqxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationResourceEntityId")]
            [Validation(Required=false)]
            public string AuthorizationResourceEntityId { get; set; }

            /// <summary>
            /// <para>The type of the resource entity that is associated with the authorized resource. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>cloud_account_role: a cloud role</description></item>
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
            /// <para>The ID of the Alibaba Cloud account to which the resource entity that is associated with the authorized resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

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
