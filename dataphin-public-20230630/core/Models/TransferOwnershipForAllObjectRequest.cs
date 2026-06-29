// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class TransferOwnershipForAllObjectRequest : TeaModel {
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
        /// <para>The transfer information.</para>
        /// </summary>
        [NameInMap("PrivilegeTransferRecord")]
        [Validation(Required=false)]
        public TransferOwnershipForAllObjectRequestPrivilegeTransferRecord PrivilegeTransferRecord { get; set; }
        public class TransferOwnershipForAllObjectRequestPrivilegeTransferRecord : TeaModel {
            /// <summary>
            /// <para>The user ID of the new owner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000002</para>
            /// </summary>
            [NameInMap("NewOwner")]
            [Validation(Required=false)]
            public string NewOwner { get; set; }

            /// <summary>
            /// <para>The user ID of the original owner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000001</para>
            /// </summary>
            [NameInMap("OldOwner")]
            [Validation(Required=false)]
            public string OldOwner { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("TransferComment")]
            [Validation(Required=false)]
            public string TransferComment { get; set; }

        }

    }

}
