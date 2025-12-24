// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeGroupProductionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the groups.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeGroupProductionsResponseBodyData> Data { get; set; }
        public class DescribeGroupProductionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud Communication</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The information about the cloud services.</para>
            /// </summary>
            [NameInMap("Productions")]
            [Validation(Required=false)]
            public List<DescribeGroupProductionsResponseBodyDataProductions> Productions { get; set; }
            public class DescribeGroupProductionsResponseBodyDataProductions : TeaModel {
                /// <summary>
                /// <para>The code of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DM</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The default requested domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dm.aliyuncs.com</para>
                /// </summary>
                [NameInMap("DefaultDomain")]
                [Validation(Required=false)]
                public string DefaultDomain { get; set; }

                /// <summary>
                /// <para>The default version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-08-15</para>
                /// </summary>
                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public string DefaultVersion { get; set; }

                /// <summary>
                /// <para>The description of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DM</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The requested domain names.</para>
                /// </summary>
                [NameInMap("FullDomains")]
                [Validation(Required=false)]
                public List<string> FullDomains { get; set; }

                /// <summary>
                /// <para>The name of the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud Communication</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The name of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DirectMail</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The RAM policies of the cloud service.</para>
                /// </summary>
                [NameInMap("PolicyList")]
                [Validation(Required=false)]
                public List<DescribeGroupProductionsResponseBodyDataProductionsPolicyList> PolicyList { get; set; }
                public class DescribeGroupProductionsResponseBodyDataProductionsPolicyList : TeaModel {
                    /// <summary>
                    /// <para>The name of the RAM policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunRAMReadOnlyAccess</para>
                    /// </summary>
                    [NameInMap("PolicyName")]
                    [Validation(Required=false)]
                    public string PolicyName { get; set; }

                    /// <summary>
                    /// <para>The type of the RAM policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>All</b>: permissions.</description></item>
                    /// <item><description><b>Read-only</b>: permissions.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>All</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The Resource Access Management (RAM) code of the POP to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dm</para>
                /// </summary>
                [NameInMap("RamCode")]
                [Validation(Required=false)]
                public string RamCode { get; set; }

                /// <summary>
                /// <para>The short name of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DM</para>
                /// </summary>
                [NameInMap("ShortName")]
                [Validation(Required=false)]
                public string ShortName { get; set; }

                /// <summary>
                /// <para>The information source of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>next</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The API versions.</para>
                /// </summary>
                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<string> Versions { get; set; }

            }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeGroupProductionsResponseBodyPage Page { get; set; }
        public class DescribeGroupProductionsResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>358E012F-****-599D-9ED0-****61CDE615</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
