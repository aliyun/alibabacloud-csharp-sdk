// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class RetryTransferOwnershipRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        [NameInMap("PrivilegeTransferRecord")]
        [Validation(Required=false)]
        public RetryTransferOwnershipRequestPrivilegeTransferRecord PrivilegeTransferRecord { get; set; }
        public class RetryTransferOwnershipRequestPrivilegeTransferRecord : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000001</para>
            /// </summary>
            [NameInMap("NewOwner")]
            [Validation(Required=false)]
            public string NewOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("TransferComment")]
            [Validation(Required=false)]
            public string TransferComment { get; set; }

        }

    }

}
