// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLogAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of log dump information.</para>
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
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0c7154xxxx</para>
                /// </summary>
                [NameInMap("MetaKey")]
                [Validation(Required=false)]
                public string MetaKey { get; set; }

                /// <summary>
                /// <para>The log dump information of the file system.</para>
                /// </summary>
                [NameInMap("MetaValue")]
                [Validation(Required=false)]
                public DescribeLogAnalysisResponseBodyAnalysesAnalysisMetaValue MetaValue { get; set; }
                public class DescribeLogAnalysisResponseBodyAnalysesAnalysisMetaValue : TeaModel {
                    /// <summary>
                    /// <para>The name of the dedicated Logstore that is used to store NAS operation logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nas-nfs</para>
                    /// </summary>
                    [NameInMap("Logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The name of the project where the dedicated Logstore resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nas-1746495857602745-cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// <para>The region where the dedicated Logstore resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The role that is used by NAS to access Simple Log Service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::162165525211xxxx:role/aliyunnaslogarchiverole</para>
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The number of log dump entries returned per page.</para>
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
        /// <para>C84F77AF-3DE5-48F1-B19B-37FCBE24****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of log dump entries in the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
