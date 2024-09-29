// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ConfigAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of turning on or off the main switch of the agent or the main switch status of the agent. Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>success</description></item>
        /// <item><description>failed</description></item>
        /// </list>
        /// <para>The main switch status of the agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abc@def success\nghi@jkl success\n</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16AF921B-8187-489F-9913-43C808B4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
