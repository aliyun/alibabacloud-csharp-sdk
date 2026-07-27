// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ListDigitalEmployeesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of digital employees.</para>
        /// </summary>
        [NameInMap("digitalEmployees")]
        [Validation(Required=false)]
        public List<ListDigitalEmployeesResponseBodyDigitalEmployees> DigitalEmployees { get; set; }
        public class ListDigitalEmployeesResponseBodyDigitalEmployees : TeaModel {
            /// <summary>
            /// <para>The custom attributes of the digital employee.</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-04T08:08:57Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The default rule of the digital employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("defaultRule")]
            [Validation(Required=false)]
            public string DefaultRule { get; set; }

            /// <summary>
            /// <para>The description of the digital employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the digital employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The type of the digital employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("employeeType")]
            [Validation(Required=false)]
            public string EmployeeType { get; set; }

            /// <summary>
            /// <para>A list of knowledge bases.</para>
            /// </summary>
            [NameInMap("knowledges")]
            [Validation(Required=false)]
            public ListDigitalEmployeesResponseBodyDigitalEmployeesKnowledges Knowledges { get; set; }
            public class ListDigitalEmployeesResponseBodyDigitalEmployeesKnowledges : TeaModel {
                /// <summary>
                /// <para>A list of Model Studio knowledge bases.</para>
                /// </summary>
                [NameInMap("bailian")]
                [Validation(Required=false)]
                public List<ListDigitalEmployeesResponseBodyDigitalEmployeesKnowledgesBailian> Bailian { get; set; }
                public class ListDigitalEmployeesResponseBodyDigitalEmployeesKnowledgesBailian : TeaModel {
                    /// <summary>
                    /// <para>The attributes of the knowledge base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("attributes")]
                    [Validation(Required=false)]
                    public string Attributes { get; set; }

                    /// <summary>
                    /// <para>The ID of the Model Studio index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>index-xxxx</para>
                    /// </summary>
                    [NameInMap("indexId")]
                    [Validation(Required=false)]
                    public string IndexId { get; set; }

                    /// <summary>
                    /// <para>The region of the knowledge base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The ID of the Model Studio workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>llm-xxxx</para>
                    /// </summary>
                    [NameInMap("workspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }

                /// <summary>
                /// <para>A list of SOP knowledge bases.</para>
                /// </summary>
                [NameInMap("sop")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Sop { get; set; }

            }

            /// <summary>
            /// <para>The name of the digital employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-ae******ey</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The RAM role ARN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::12345678912:role/testrole</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
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
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
