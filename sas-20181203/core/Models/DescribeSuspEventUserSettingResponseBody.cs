// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventUserSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the risk levels of alert notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>remind</b></description></item>
        /// <item><description><b>suspicious</b></description></item>
        /// <item><description><b>serious</b></description></item>
        /// </list>
        /// </summary>
        [NameInMap("LevelsOn")]
        [Validation(Required=false)]
        public List<string> LevelsOn { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>028CF634-5268-5660-9575-48C9ED6XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
