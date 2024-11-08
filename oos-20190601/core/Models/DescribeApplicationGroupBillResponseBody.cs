// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DescribeApplicationGroupBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The consume of application group.</para>
        /// </summary>
        [NameInMap("ApplicationGroupConsume")]
        [Validation(Required=false)]
        public List<DescribeApplicationGroupBillResponseBodyApplicationGroupConsume> ApplicationGroupConsume { get; set; }
        public class DescribeApplicationGroupBillResponseBodyApplicationGroupConsume : TeaModel {
            /// <summary>
            /// <para>The amount consumed by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.88</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public float? Amount { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-10T06:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The currency unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-0jl781czrhqey0s5zpsj</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::INSTANCE</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Optimization suggestions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Optimization")]
            [Validation(Required=false)]
            public string Optimization { get; set; }

            /// <summary>
            /// <para>The peak type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WHITE</para>
            /// </summary>
            [NameInMap("PeakType")]
            [Validation(Required=false)]
            public string PeakType { get; set; }

            /// <summary>
            /// <para>The performance of the data synchronization instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;mem\&quot;:\&quot;6.82\&quot;,\&quot;cpu\&quot;:\&quot;0.55\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("Performance")]
            [Validation(Required=false)]
            public string Performance { get; set; }

            /// <summary>
            /// <para>The status of instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E897A1AB-4701-5B71-93AD-38FD703763A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
