// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRatePlanInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xcdn-91fknmb80f0g***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Instance status, with possible values:</para>
        /// <list type="bullet">
        /// <item><description>running: Running</description></item>
        /// <item><description>renewing: Renewing</description></item>
        /// <item><description>upgrading: Upgrading</description></item>
        /// <item><description>releasePrepaidService: Prepaid service released due to expiration</description></item>
        /// <item><description>creating: Creating</description></item>
        /// <item><description>downgrading: Downgrading</description></item>
        /// <item><description>ceasePrepaidService: Prepaid service ceased upon expiration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60423A7F-A83D-1E24-B80E-86DD25790759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
