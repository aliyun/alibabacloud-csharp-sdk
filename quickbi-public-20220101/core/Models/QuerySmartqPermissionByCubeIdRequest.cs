// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QuerySmartqPermissionByCubeIdRequest : TeaModel {
        /// <summary>
        /// <para>Dataset ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95c4d**************3852e202</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
