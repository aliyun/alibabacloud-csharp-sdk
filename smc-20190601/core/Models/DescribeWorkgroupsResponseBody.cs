// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeWorkgroupsResponseBody : TeaModel {
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
        /// <para>The number of entries per page. Valid values: 1 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF518948****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of workgroups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The queried workgroups.</para>
        /// </summary>
        [NameInMap("Workgroups")]
        [Validation(Required=false)]
        public DescribeWorkgroupsResponseBodyWorkgroups Workgroups { get; set; }
        public class DescribeWorkgroupsResponseBodyWorkgroups : TeaModel {
            [NameInMap("Workgroup")]
            [Validation(Required=false)]
            public List<DescribeWorkgroupsResponseBodyWorkgroupsWorkgroup> Workgroup { get; set; }
            public class DescribeWorkgroupsResponseBodyWorkgroupsWorkgroup : TeaModel {
                /// <summary>
                /// <para>The description of the workgroup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the workgroup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testWorkgroupName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The state of the workgroup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NotStarted</description></item>
                /// <item><description>InProgress</description></item>
                /// <item><description>Cutover</description></item>
                /// <item><description>Completed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InProgress</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag information of the workgroup.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupTags Tags { get; set; }
                public class DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupTagsTag> Tag { get; set; }
                    public class DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the workgroup.</para>
                        /// <para>You can specify an empty string as a tag key. The tag key can be up to 64 characters in length and cannot contain http:// or https://.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value of the workgroup. Valid values of N: 1 to 20.</para>
                        /// <para>You can specify an empty string as a tag value. The tag value can be up to 64 characters in length and cannot contain http:// or https://.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The alert information of the workgroup, which can contain multiple types of alerts.</para>
                /// </summary>
                [NameInMap("Warnings")]
                [Validation(Required=false)]
                public DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupWarnings Warnings { get; set; }
                public class DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupWarnings : TeaModel {
                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public List<DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupWarningsWarning> Warning { get; set; }
                    public class DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupWarningsWarning : TeaModel {
                        /// <summary>
                        /// <para>The migration sources for which alerts are generated.</para>
                        /// </summary>
                        [NameInMap("SourceIds")]
                        [Validation(Required=false)]
                        public DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupWarningsWarningSourceIds SourceIds { get; set; }
                        public class DescribeWorkgroupsResponseBodyWorkgroupsWorkgroupWarningsWarningSourceIds : TeaModel {
                            [NameInMap("SourceId")]
                            [Validation(Required=false)]
                            public List<string> SourceId { get; set; }

                        }

                        /// <summary>
                        /// <para>The type of the alert. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>InError: A migration job failed.</description></item>
                        /// <item><description>UnRelated: No migration job is created for a migration source.</description></item>
                        /// <item><description>NotPassed: A migration job failed to pass the migration test.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>InError</para>
                        /// </summary>
                        [NameInMap("WarningType")]
                        [Validation(Required=false)]
                        public string WarningType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The workgroup ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>w-***</para>
                /// </summary>
                [NameInMap("WorkgroupId")]
                [Validation(Required=false)]
                public string WorkgroupId { get; set; }

            }

        }

    }

}
