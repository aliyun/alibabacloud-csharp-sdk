// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DeleteUserRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f5****afccd9e434a274</para>
        /// </summary>
        [NameInMap("TransferUserId")]
        [Validation(Required=false)]
        public string TransferUserId { get; set; }

        /// <summary>
        /// <para>Deletes a user from a specified organization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
