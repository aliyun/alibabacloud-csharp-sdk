// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeJVSInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeJVSInstanceResponseBodyData> Data { get; set; }
        public class DescribeJVSInstanceResponseBodyData : TeaModel {
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public DescribeJVSInstanceResponseBodyDataAgentVersion AgentVersion { get; set; }
            public class DescribeJVSInstanceResponseBodyDataAgentVersion : TeaModel {
                [NameInMap("UpgradeStatus")]
                [Validation(Required=false)]
                public string UpgradeStatus { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The time is in UTC and follows the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T01:31:32Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The credit limit configuration. Subsequent quota configurations overwrite previous configurations.</para>
            /// </summary>
            [NameInMap("CreditConfig")]
            [Validation(Required=false)]
            public List<DescribeJVSInstanceResponseBodyDataCreditConfig> CreditConfig { get; set; }
            public class DescribeJVSInstanceResponseBodyDataCreditConfig : TeaModel {
                /// <summary>
                /// <para>The limit value.</para>
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
            /// <para>The expiration time. The time is in UTC and follows the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T01:31:32Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("InstalledSkills")]
            [Validation(Required=false)]
            public List<DescribeJVSInstanceResponseBodyDataInstalledSkills> InstalledSkills { get; set; }
            public class DescribeJVSInstanceResponseBodyDataInstalledSkills : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                [NameInMap("InstalledAt")]
                [Validation(Required=false)]
                public string InstalledAt { get; set; }

                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

                [NameInMap("SkillName")]
                [Validation(Required=false)]
                public string SkillName { get; set; }

                [NameInMap("SkillType")]
                [Validation(Required=false)]
                public string SkillType { get; set; }

            }

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
            /// <para>The modification time. The time is in UTC and follows the ISO 8601 standard.</para>
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
            /// <para>The used credit.</para>
            /// </summary>
            [NameInMap("UsedCredit")]
            [Validation(Required=false)]
            public List<DescribeJVSInstanceResponseBodyDataUsedCredit> UsedCredit { get; set; }
            public class DescribeJVSInstanceResponseBodyDataUsedCredit : TeaModel {
                /// <summary>
                /// <para>The number of credits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Credit")]
                [Validation(Required=false)]
                public long? Credit { get; set; }

                /// <summary>
                /// <para>The dimension of the current credit.</para>
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
        /// <para>The maximum number of results returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the starting position for the next query. An empty value indicates that the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PendingUpgradeCount")]
        [Validation(Required=false)]
        public int? PendingUpgradeCount { get; set; }

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
