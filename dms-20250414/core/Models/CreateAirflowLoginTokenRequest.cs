// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateAirflowLoginTokenRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af-b3a7f110a6vmvn7xxxxxx</para>
        /// </summary>
        [NameInMap("AirflowId")]
        [Validation(Required=false)]
        public string AirflowId { get; set; }

    }

}
