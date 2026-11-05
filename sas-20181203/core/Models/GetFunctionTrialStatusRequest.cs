// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFunctionTrialStatusRequest : TeaModel {
        /// <summary>
        /// <para>The name of the feature module. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>trail_file_detect_api_reward: File detection API trial.</para>
        /// </description></item>
        /// <item><description><para>trail_honeypot_reward: Honeypot trial.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required. If it is not provided, the API returns an HTTP 400 error with the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>trail_file_detect_api_reward</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

    }

}
