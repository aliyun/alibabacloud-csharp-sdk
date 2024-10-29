// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateIdpDepartmentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DepartmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1222</para>
        /// </summary>
        [NameInMap("IdpConfigId")]
        [Validation(Required=false)]
        public string IdpConfigId { get; set; }

    }

}
