// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLogAnalysisResponseBody : TeaModel {
        /// <summary>
        /// The collection of log dump information.
        /// </summary>
        [NameInMap("Analyses")]
        [Validation(Required=false)]
        public DescribeLogAnalysisResponseBodyAnalyses Analyses { get; set; }
        public class DescribeLogAnalysisResponseBodyAnalyses : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public List<DescribeLogAnalysisResponseBodyAnalysesAnalysis> Analysis { get; set; }
            public class DescribeLogAnalysisResponseBodyAnalysesAnalysis : TeaModel {
                /// <summary>
                /// The ID of the file system.
                /// </summary>
                [NameInMap("MetaKey")]
                [Validation(Required=false)]
                public string MetaKey { get; set; }

                /// <summary>
                /// The log dump information of the file system.
                /// </summary>
                [NameInMap("MetaValue")]
                [Validation(Required=false)]
                public DescribeLogAnalysisResponseBodyAnalysesAnalysisMetaValue MetaValue { get; set; }
                public class DescribeLogAnalysisResponseBodyAnalysesAnalysisMetaValue : TeaModel {
                    /// <summary>
                    /// The name of the dedicated Logstore that is used to store NAS operation logs.
                    /// </summary>
                    [NameInMap("Logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// The name of the project where the dedicated Logstore resides.
                    /// </summary>
                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// The region where the dedicated Logstore resides.
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// The role that is used by NAS to access Simple Log Service.
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

            }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of log dump entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of log dump entries in the region.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
