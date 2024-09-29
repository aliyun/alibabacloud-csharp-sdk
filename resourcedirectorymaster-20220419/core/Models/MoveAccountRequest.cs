// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class MoveAccountRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member that you want to move.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The ID of the destination folder.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-bVaRIG****</para>
        /// </summary>
        [NameInMap("DestinationFolderId")]
        [Validation(Required=false)]
        public string DestinationFolderId { get; set; }

    }

}
