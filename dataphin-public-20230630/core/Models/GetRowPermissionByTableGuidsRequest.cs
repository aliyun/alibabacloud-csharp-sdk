// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetRowPermissionByTableGuidsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GetRowPermissionByTableGuidsQuery")]
        [Validation(Required=false)]
        public GetRowPermissionByTableGuidsRequestGetRowPermissionByTableGuidsQuery GetRowPermissionByTableGuidsQuery { get; set; }
        public class GetRowPermissionByTableGuidsRequestGetRowPermissionByTableGuidsQuery : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("TableGuids")]
            [Validation(Required=false)]
            public List<string> TableGuids { get; set; }

        }

        /// <summary>
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
