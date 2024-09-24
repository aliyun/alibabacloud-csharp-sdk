// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserLayoutAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The brute-force attacks protection feature has been authorized.</description></item>
        /// <item><description><b>false</b>: The brute-force attacks protection feature is not authorized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Authorized")]
        [Validation(Required=false)]
        public bool? Authorized { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A80EE8F-2175-49DA-B8BF-FAE1B3D52E4C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
