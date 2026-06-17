// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterConnectivityResponseBody : TeaModel {
        /// <summary>
        /// <para>The connection check error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SRC_IP_NOT_IN_USER_WHITELIST</b>: The source IP address is not in the whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>CONNECTION_ABNORMAL</b>: The connection is abnormal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SRC_IP_NOT_IN_USER_WHITELIST</para>
        /// </summary>
        [NameInMap("ConnCheckErrorCode")]
        [Validation(Required=false)]
        public string ConnCheckErrorCode { get; set; }

        /// <summary>
        /// <para>The connection check error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Src ip:192.<em><b>.</b></em>.1 not in user whitelist</para>
        /// </summary>
        [NameInMap("ConnCheckErrorMessage")]
        [Validation(Required=false)]
        public string ConnCheckErrorMessage { get; set; }

        /// <summary>
        /// <para>The connection check result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Success</b></para>
        /// </description></item>
        /// <item><description><para><b>Failed</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Failed</para>
        /// </summary>
        [NameInMap("ConnCheckResult")]
        [Validation(Required=false)]
        public string ConnCheckResult { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73A85BAF-1039-4CDE-A83F-1A140F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
