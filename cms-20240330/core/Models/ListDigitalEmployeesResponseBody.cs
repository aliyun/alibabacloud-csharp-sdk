// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListDigitalEmployeesResponseBody : TeaModel {
        [NameInMap("digitalEmployees")]
        [Validation(Required=false)]
        public List<ListDigitalEmployeesResponseBodyDigitalEmployees> DigitalEmployees { get; set; }
        public class ListDigitalEmployeesResponseBodyDigitalEmployees : TeaModel {
            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-04T08:08:57Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("defaultRule")]
            [Validation(Required=false)]
            public string DefaultRule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("employeeType")]
            [Validation(Required=false)]
            public string EmployeeType { get; set; }

            [NameInMap("knowledges")]
            [Validation(Required=false)]
            public ListDigitalEmployeesResponseBodyDigitalEmployeesKnowledges Knowledges { get; set; }
            public class ListDigitalEmployeesResponseBodyDigitalEmployeesKnowledges : TeaModel {
                [NameInMap("bailian")]
                [Validation(Required=false)]
                public List<ListDigitalEmployeesResponseBodyDigitalEmployeesKnowledgesBailian> Bailian { get; set; }
                public class ListDigitalEmployeesResponseBodyDigitalEmployeesKnowledgesBailian : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("attributes")]
                    [Validation(Required=false)]
                    public string Attributes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>index-xxxx</para>
                    /// </summary>
                    [NameInMap("indexId")]
                    [Validation(Required=false)]
                    public string IndexId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>llm-xxxx</para>
                    /// </summary>
                    [NameInMap("workspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }

                [NameInMap("sop")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Sop { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-ae******ey</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::12345678912:role/testrole</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-07T02:26:01Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>56</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
