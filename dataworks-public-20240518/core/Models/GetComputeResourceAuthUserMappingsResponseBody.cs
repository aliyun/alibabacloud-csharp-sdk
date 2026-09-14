// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetComputeResourceAuthUserMappingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetComputeResourceAuthUserMappingsResponseBodyData Data { get; set; }
        public class GetComputeResourceAuthUserMappingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of mapped account information.</para>
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<GetComputeResourceAuthUserMappingsResponseBodyDataAccounts> Accounts { get; set; }
            public class GetComputeResourceAuthUserMappingsResponseBodyDataAccounts : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12747300953xxx62</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username in the target system, such as an LDAP account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jsmitxxxx</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The authentication type, such as LDAP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldap</para>
            /// </summary>
            [NameInMap("HadoopAuthType")]
            [Validation(Required=false)]
            public string HadoopAuthType { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
