// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAdviceServiceEnabledResponseBody : TeaModel {
        /// <summary>
        /// <para>The message returned for the call result. </para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, <b>Success</b> is returned. </description></item>
        /// <item><description>If the request fails, the specific error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E031AABF-BD56-5966-A063-4283EF18DB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the advisory service is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: Enabled. </description></item>
        /// <item><description><b>False</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
