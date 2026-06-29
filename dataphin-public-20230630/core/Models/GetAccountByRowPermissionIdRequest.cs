// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAccountByRowPermissionIdRequest : TeaModel {
        /// <summary>
        /// <para>The request command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GetAccountByRowPermissionIdQuery")]
        [Validation(Required=false)]
        public GetAccountByRowPermissionIdRequestGetAccountByRowPermissionIdQuery GetAccountByRowPermissionIdQuery { get; set; }
        public class GetAccountByRowPermissionIdRequestGetAccountByRowPermissionIdQuery : TeaModel {
            /// <summary>
            /// <para>The row-level permission ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001234</para>
            /// </summary>
            [NameInMap("RowPermissionId")]
            [Validation(Required=false)]
            public long? RowPermissionId { get; set; }

            /// <summary>
            /// <para>The row-level permission rule IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public List<long?> RuleIds { get; set; }

        }

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

    }

}
