// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHADiagnoseConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06B220E2-EAC5-4DBE-A1FC-1B62DB6A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The availability check method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LONG</b>: Alibaba Cloud uses persistent connections to check the availability of the instance.</description></item>
        /// <item><description><b>SHORT</b>: Alibaba Cloud uses short-lived connections to check the availability of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LONG</para>
        /// </summary>
        [NameInMap("TcpConnectionType")]
        [Validation(Required=false)]
        public string TcpConnectionType { get; set; }

    }

}
