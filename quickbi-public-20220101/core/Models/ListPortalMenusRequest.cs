// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListPortalMenusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the BI portal.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d173abb53e84c8ca7495429163b****</para>
        /// </summary>
        [NameInMap("DataPortalId")]
        [Validation(Required=false)]
        public string DataPortalId { get; set; }

        /// <summary>
        /// <para>The user ID in the Quick BI. When passed in, the list displays only the menus that the user has permissions on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567***</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
