// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ReceiveFunctionTrialRewardByAliUidRequest : TeaModel {
        /// <summary>
        /// <para>The name of the feature for which you want to apply for a free trial. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>trail_honeypot_reward</b>: cloud honeypot</description></item>
        /// <item><description><b>trail_file_detect_api_reward</b>: SDK for malicious file detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>trail_honeypot_reward</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
