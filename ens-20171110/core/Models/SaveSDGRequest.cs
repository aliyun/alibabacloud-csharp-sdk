// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SaveSDGRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SDG to save.</para>
        /// <para>This parameter is required. If this parameter is not specified, the service returns a Parameter.Invalid error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdg-xxxx</para>
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}
