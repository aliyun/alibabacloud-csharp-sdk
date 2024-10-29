// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteIdpDepartmentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10829</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>507</para>
        /// </summary>
        [NameInMap("IdpConfigId")]
        [Validation(Required=false)]
        public string IdpConfigId { get; set; }

    }

}
