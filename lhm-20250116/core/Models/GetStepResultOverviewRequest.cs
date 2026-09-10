// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetStepResultOverviewRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the validation result.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001</para>
        /// </summary>
        [NameInMap("resultId")]
        [Validation(Required=false)]
        public string ResultId { get; set; }

    }

}
