// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRatePlanInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xcdn-91fknmb80f0g***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>running: The instance is running.</description></item>
        /// <item><description>renewing: The instance is being renewed.</description></item>
        /// <item><description>upgrading: The configuration of the instance is being upgraded.</description></item>
        /// <item><description>releasePrepaidService: The instance is released due to expiration.</description></item>
        /// <item><description>creating: The instance is being created.</description></item>
        /// <item><description>downgrading: The configuration of the instance is being downgraded.</description></item>
        /// <item><description>ceasePrepaidService: The instance has expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60423A7F-A83D-1E24-B80E-86DD25790759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
