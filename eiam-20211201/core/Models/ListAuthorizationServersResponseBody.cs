// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListAuthorizationServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of authorization servers.</para>
        /// </summary>
        [NameInMap("AuthorizationServers")]
        [Validation(Required=false)]
        public List<ListAuthorizationServersResponseBodyAuthorizationServers> AuthorizationServers { get; set; }
        public class ListAuthorizationServersResponseBodyAuthorizationServers : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the authorization server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iauths_system</para>
            /// </summary>
            [NameInMap("AuthorizationServerId")]
            [Validation(Required=false)]
            public string AuthorizationServerId { get; set; }

            /// <summary>
            /// <para>The name of the authorization server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_authorization_server</para>
            /// </summary>
            [NameInMap("AuthorizationServerName")]
            [Validation(Required=false)]
            public string AuthorizationServerName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("CreationType")]
            [Validation(Required=false)]
            public string CreationType { get; set; }

            /// <summary>
            /// <para>The description of the authorization server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description of authorization server</para>
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
            /// <para>The currently active issuer address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/token">https://xxxx.aliyunidaas.com/api/v2/iauths_system/oauth2/token</a></para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The domain name used by the issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx.aliyunidaas.com</para>
            /// </summary>
            [NameInMap("IssuerDomain")]
            [Validation(Required=false)]
            public string IssuerDomain { get; set; }

            /// <summary>
            /// <para>The issuer mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("IssuerMode")]
            [Validation(Required=false)]
            public string IssuerMode { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned in this call.</para>
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
        /// <para>The total number of authorization servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
