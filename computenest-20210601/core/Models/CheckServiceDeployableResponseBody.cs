// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CheckServiceDeployableResponseBody : TeaModel {
        /// <summary>
        /// <para>The check results.</para>
        /// </summary>
        [NameInMap("CheckResults")]
        [Validation(Required=false)]
        public List<CheckServiceDeployableResponseBodyCheckResults> CheckResults { get; set; }
        public class CheckServiceDeployableResponseBodyCheckResults : TeaModel {
            /// <summary>
            /// <para>The message returned for the result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Skippable")]
            [Validation(Required=false)]
            public bool? Skippable { get; set; }

            /// <summary>
            /// <para>The type of precheck. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Balance: The account balance.</para>
            /// </description></item>
            /// <item><description><para>Quota: The resource quota.</para>
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
            /// <para>The check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06BF8F22-02DC-4750-83DF-3FFC11C065EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
