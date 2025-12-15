// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDbInstanceConnectivityResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code for connection diagnosis. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SRC_IP_NOT_IN_USER_WHITELIST</b>: The source IP address is not added to the whitelist.</description></item>
        /// <item><description><b>CONNECTION_ABNORMAL</b>: The connection to the instance is normal.</description></item>
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
        /// <para>Src ip:172.28.134.96 not in user whitelist</para>
        /// </summary>
        [NameInMap("ConnCheckErrorMessage")]
        [Validation(Required=false)]
        public string ConnCheckErrorMessage { get; set; }

        /// <summary>
        /// <para>The connection check result. Valid values:</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BE6E619-A657-42E3-AD2D-18F8428A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
