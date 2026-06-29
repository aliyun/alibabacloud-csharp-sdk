// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class RevokeDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The data service project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102102</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// <para>The revoke instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RevokeCommand")]
        [Validation(Required=false)]
        public RevokeDataServiceApiRequestRevokeCommand RevokeCommand { get; set; }
        public class RevokeDataServiceApiRequestRevokeCommand : TeaModel {
            /// <summary>
            /// <para>The API ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1021</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1203</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The permission type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USE: use permission</description></item>
            /// <item><description>DELEGATION: delegation permission.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USE</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The API environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: development environment</description></item>
            /// <item><description>PROD: production environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PROD</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The authorization object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APP: application</description></item>
            /// <item><description>USER: user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APP</para>
            /// </summary>
            [NameInMap("GranteeType")]
            [Validation(Required=false)]
            public string GranteeType { get; set; }

            /// <summary>
            /// <para>The reason for the request.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
