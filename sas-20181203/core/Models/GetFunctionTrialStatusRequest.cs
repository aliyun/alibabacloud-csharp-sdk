// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFunctionTrialStatusRequest : TeaModel {
        /// <summary>
        /// <para>The name of the function module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail_file_detect_api_reward</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

    }

}
