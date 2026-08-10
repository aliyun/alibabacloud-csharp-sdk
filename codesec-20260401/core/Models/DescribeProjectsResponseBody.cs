// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeProjectsResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DescribeProjectsResponseBodyItems> Items { get; set; }
        public class DescribeProjectsResponseBodyItems : TeaModel {
            [NameInMap("configRevision")]
            [Validation(Required=false)]
            public long? ConfigRevision { get; set; }

            /// <summary>
            /// <para>扫描项目创建时间（RFC3339）</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("engines")]
            [Validation(Required=false)]
            public DescribeProjectsResponseBodyItemsEngines Engines { get; set; }
            public class DescribeProjectsResponseBodyItemsEngines : TeaModel {
                [NameInMap("sast")]
                [Validation(Required=false)]
                public bool? Sast { get; set; }

                [NameInMap("sca")]
                [Validation(Required=false)]
                public bool? Sca { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("instructionPrompt")]
            [Validation(Required=false)]
            public string InstructionPrompt { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public DescribeProjectsResponseBodyItemsSource Source { get; set; }
            public class DescribeProjectsResponseBodyItemsSource : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>扫描项目更新时间（RFC3339）</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
