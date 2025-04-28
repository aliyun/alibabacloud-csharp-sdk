// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class DeleteRowPermissionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeleteRowPermissionCommand")]
        [Validation(Required=false)]
        public DeleteRowPermissionRequestDeleteRowPermissionCommand DeleteRowPermissionCommand { get; set; }
        public class DeleteRowPermissionRequestDeleteRowPermissionCommand : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001234</para>
            /// </summary>
            [NameInMap("RowPermissionId")]
            [Validation(Required=false)]
            public long? RowPermissionId { get; set; }

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
