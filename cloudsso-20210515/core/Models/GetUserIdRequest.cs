// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The identifier information about the user that is synchronized from an external identity provider (IdP).</para>
        /// </summary>
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public GetUserIdRequestExternalId ExternalId { get; set; }
        public class GetUserIdRequestExternalId : TeaModel {
            /// <summary>
            /// <para>The identifier of the user that is synchronized from an external IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c73******a5fdd5</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The method for external identity synchronization. Only System for Cross-domain Identity Management (SCIM) synchronization is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SCIM</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

        }

    }

}
