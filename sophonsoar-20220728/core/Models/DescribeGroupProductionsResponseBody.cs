// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeGroupProductionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeGroupProductionsResponseBodyData> Data { get; set; }
        public class DescribeGroupProductionsResponseBodyData : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("Productions")]
            [Validation(Required=false)]
            public List<DescribeGroupProductionsResponseBodyDataProductions> Productions { get; set; }
            public class DescribeGroupProductionsResponseBodyDataProductions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Rds</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("DefaultDomain")]
                [Validation(Required=false)]
                public string DefaultDomain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2014-08-15</para>
                /// </summary>
                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public string DefaultVersion { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FullDomains")]
                [Validation(Required=false)]
                public List<string> FullDomains { get; set; }

                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PolicyList")]
                [Validation(Required=false)]
                public List<DescribeGroupProductionsResponseBodyDataProductionsPolicyList> PolicyList { get; set; }
                public class DescribeGroupProductionsResponseBodyDataProductionsPolicyList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AliyunRAMReadOnlyAccess</para>
                    /// </summary>
                    [NameInMap("PolicyName")]
                    [Validation(Required=false)]
                    public string PolicyName { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("RamCode")]
                [Validation(Required=false)]
                public string RamCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("ShortName")]
                [Validation(Required=false)]
                public string ShortName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>next</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<string> Versions { get; set; }

            }

        }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeGroupProductionsResponseBodyPage Page { get; set; }
        public class DescribeGroupProductionsResponseBodyPage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>358E012F-B516-599D-9ED0-A1A361CDE615</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
