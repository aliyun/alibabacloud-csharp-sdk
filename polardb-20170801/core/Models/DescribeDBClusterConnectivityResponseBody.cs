// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterConnectivityResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code for connection diagnosis. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SRC_IP_NOT_IN_USER_WHITELIST</b>: The source IP address is not added to the whitelist.</description></item>
        /// <item><description><b>CONNECTION_ABNORMAL</b>: The connection to the cluster is normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SRC_IP_NOT_IN_USER_WHITELIST</para>
        /// </summary>
        [NameInMap("ConnCheckErrorCode")]
        [Validation(Required=false)]
        public string ConnCheckErrorCode { get; set; }

        /// <summary>
        /// <para>The error message for connection diagnosis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Src ip:192.<em><b>.</b></em>.1 not in user whitelist</para>
        /// </summary>
        [NameInMap("ConnCheckErrorMessage")]
        [Validation(Required=false)]
        public string ConnCheckErrorMessage { get; set; }

        /// <summary>
        /// <para>The connection diagnosis result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b></description></item>
        /// <item><description><b>Failed</b></description></item>
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
