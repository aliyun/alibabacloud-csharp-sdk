// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetPermissionByCodeRequest : TeaModel {
        /// <summary>
        /// <para>Authorize code information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow_001</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The space ID of the RAM user within the independent software vendor (ISV) account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393847477</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The permissions.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<string> Permissions { get; set; }

    }

}
