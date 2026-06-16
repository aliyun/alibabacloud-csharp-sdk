// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetResourceServerScopeResponseBody : TeaModel {
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
        /// <para>The information about the scope permission of the resource server.</para>
        /// </summary>
        [NameInMap("ResourceServerScope")]
        [Validation(Required=false)]
        public GetResourceServerScopeResponseBodyResourceServerScope ResourceServerScope { get; set; }
        public class GetResourceServerScopeResponseBodyResourceServerScope : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The authorization type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>authorize_required</para>
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the scope permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rss_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceServerScopeId")]
            [Validation(Required=false)]
            public string ResourceServerScopeId { get; set; }

            /// <summary>
            /// <para>The name of the scope permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Read User Info</para>
            /// </summary>
            [NameInMap("ResourceServerScopeName")]
            [Validation(Required=false)]
            public string ResourceServerScopeName { get; set; }

            /// <summary>
            /// <para>The type of the scope permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:resourceserver:scope:delegated</para>
            /// </summary>
            [NameInMap("ResourceServerScopeType")]
            [Validation(Required=false)]
            public string ResourceServerScopeType { get; set; }

            /// <summary>
            /// <para>The value of the scope permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User:Read:ALL</para>
            /// </summary>
            [NameInMap("ResourceServerScopeValue")]
            [Validation(Required=false)]
            public string ResourceServerScopeValue { get; set; }

        }

    }

}
