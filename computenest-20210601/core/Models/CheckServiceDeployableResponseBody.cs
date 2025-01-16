// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CheckServiceDeployableResponseBody : TeaModel {
        /// <summary>
        /// <para>Inspection result.</para>
        /// </summary>
        [NameInMap("CheckResults")]
        [Validation(Required=false)]
        public List<CheckServiceDeployableResponseBodyCheckResults> CheckResults { get; set; }
        public class CheckServiceDeployableResponseBodyCheckResults : TeaModel {
            /// <summary>
            /// <para>Returns a hint message for the result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Check type, invalid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Balance ：Account balance.</para>
            /// </description></item>
            /// <item><description><para>Quota:  Account quota.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Balance</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Inspection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>06BF8F22-02DC-4750-83DF-3FFC11C065EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
