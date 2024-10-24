// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeStsGrantStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6623EA1F-30FB-5BC8-BEC9-74D55F6F08F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The authorization status of Anti-DDoS Pro or Anti-DDoS Premium.</para>
        /// </summary>
        [NameInMap("StsGrant")]
        [Validation(Required=false)]
        public DescribeStsGrantStatusResponseBodyStsGrant StsGrant { get; set; }
        public class DescribeStsGrantStatusResponseBodyStsGrant : TeaModel {
            /// <summary>
            /// <para>The authorization status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Anti-DDoS Pro or Anti-DDoS Premium is not authorized to access other cloud services.</description></item>
            /// <item><description><b>1</b>: Anti-DDoS Pro or Anti-DDoS Premium is authorized to access other cloud services.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
