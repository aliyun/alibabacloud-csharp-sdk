// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeJVSInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of JVS instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeJVSInstanceResponseBodyData> Data { get; set; }
        public class DescribeJVSInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T01:31:32Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Credit limit configuration. If you apply multiple configurations, the latest one overwrites the others.</para>
            /// </summary>
            [NameInMap("CreditConfig")]
            [Validation(Required=false)]
            public List<DescribeJVSInstanceResponseBodyDataCreditConfig> CreditConfig { get; set; }
            public class DescribeJVSInstanceResponseBodyDataCreditConfig : TeaModel {
                /// <summary>
                /// <para>The Credit limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("CreditLimit")]
                [Validation(Required=false)]
                public long? CreditLimit { get; set; }

                /// <summary>
                /// <para>The limit period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("LimitPeriod")]
                [Validation(Required=false)]
                public string LimitPeriod { get; set; }

            }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T01:31:32Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-uto81vfd8t8z****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("JvsPackageId")]
            [Validation(Required=false)]
            public string JvsPackageId { get; set; }

            /// <summary>
            /// <para>The time the instance was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T01:31:32Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The amount of used Credit.</para>
            /// </summary>
            [NameInMap("UsedCredit")]
            [Validation(Required=false)]
            public List<DescribeJVSInstanceResponseBodyDataUsedCredit> UsedCredit { get; set; }
            public class DescribeJVSInstanceResponseBodyDataUsedCredit : TeaModel {
                /// <summary>
                /// <para>The amount of Credit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Credit")]
                [Validation(Required=false)]
                public long? Credit { get; set; }

                /// <summary>
                /// <para>The calculation period for used Credit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("LimitPeriod")]
                [Validation(Required=false)]
                public string LimitPeriod { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this field is empty, there are no more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
