// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListStacksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LC4NJL3Ru2bIiRdnbADPQp4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3E49127A-BB65-5CCD-AB93-0EC0A43E5446</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("stacks")]
        [Validation(Required=false)]
        public List<ListStacksResponseBodyStacks> Stacks { get; set; }
        public class ListStacksResponseBodyStacks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-07T02:21:28Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description of stack</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stack-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description of stack</para>
            /// </summary>
            [NameInMap("stackDescription")]
            [Validation(Required=false)]
            public string StackDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stack-as1d4vld898ppnqxxxxxx</para>
            /// </summary>
            [NameInMap("stackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stack-test</para>
            /// </summary>
            [NameInMap("stackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
