// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryEmployeeDetailRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc12138</para>
        /// </summary>
        [NameInMap("out_employee_id")]
        [Validation(Required=false)]
        public string OutEmployeeId { get; set; }

    }

}
