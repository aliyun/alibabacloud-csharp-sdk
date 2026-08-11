// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListStacksResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. This parameter is empty if no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LC4NJL3Ru2bIiRdnbADPQp4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E49127A-BB65-5CCD-AB93-0EC0A43E5446</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of stacks.</para>
        /// </summary>
        [NameInMap("stacks")]
        [Validation(Required=false)]
        public List<ListStacksResponseBodyStacks> Stacks { get; set; }
        public class ListStacksResponseBodyStacks : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-07T02:21:28Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description of stack</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The stack name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The creation source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: a template stored in Object Storage Service (OSS).</description></item>
            /// <item><description>IAC_SERVICE_MODULE: a template created in the automation service console.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The path value of the configuration source. The value cannot exceed 1000 characters.</para>
            /// <list type="bullet">
            /// <item><description>If the source is OSS, the value is in the format oss::<file link> and must be a zip file. Example: oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></description></item>
            /// <item><description>If the source is IAC_SERVICE_MODULE, the value is a template ID. Example: mod-xxxxx</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <para>The description of the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description of stack</para>
            /// </summary>
            [NameInMap("stackDescription")]
            [Validation(Required=false)]
            public string StackDescription { get; set; }

            /// <summary>
            /// <para>The stack ID, which is the unique identifier generated after the stack is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-as1d4vld898ppnqxxxxxx</para>
            /// </summary>
            [NameInMap("stackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <para>The stack name (deprecated). Use name instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-test</para>
            /// </summary>
            [NameInMap("stackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <para>The stack status.</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Name</th>
            /// <th>Description</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>Creating</td>
            /// <td>Being created.</td>
            /// </tr>
            /// <tr>
            /// <td>Created</td>
            /// <td>Created.</td>
            /// </tr>
            /// <tr>
            /// <td>Waiting</td>
            /// <td>Waiting for deployment.</td>
            /// </tr>
            /// <tr>
            /// <td>Deploying</td>
            /// <td>Being deployed.</td>
            /// </tr>
            /// <tr>
            /// <td>Deployed</td>
            /// <td>Deployed.</td>
            /// </tr>
            /// <tr>
            /// <td>Errored</td>
            /// <td>Deployment failed.</td>
            /// </tr>
            /// <tr>
            /// <td>Deleting</td>
            /// <td>Being deleted.</td>
            /// </tr>
            /// <tr>
            /// <td>Deleted</td>
            /// <td>Deleted.</td>
            /// </tr>
            /// <tr>
            /// <td>DeleteFailed</td>
            /// <td>Deletion failed.</td>
            /// </tr>
            /// </tbody></table>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
