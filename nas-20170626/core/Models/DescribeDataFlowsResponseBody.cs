// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowsResponseBody : TeaModel {
        [NameInMap("DataFlowInfo")]
        [Validation(Required=false)]
        public DescribeDataFlowsResponseBodyDataFlowInfo DataFlowInfo { get; set; }
        public class DescribeDataFlowsResponseBodyDataFlowInfo : TeaModel {
            [NameInMap("DataFlow")]
            [Validation(Required=false)]
            public List<DescribeDataFlowsResponseBodyDataFlowInfoDataFlow> DataFlow { get; set; }
            public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlow : TeaModel {
                [NameInMap("AutoRefresh")]
                [Validation(Required=false)]
                public DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefresh AutoRefresh { get; set; }
                public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefresh : TeaModel {
                    [NameInMap("AutoRefresh")]
                    [Validation(Required=false)]
                    public List<DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefreshAutoRefresh> AutoRefresh { get; set; }
                    public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefreshAutoRefresh : TeaModel {
                        [NameInMap("RefreshPath")]
                        [Validation(Required=false)]
                        public string RefreshPath { get; set; }

                    }

                }

                [NameInMap("AutoRefreshInterval")]
                [Validation(Required=false)]
                public long? AutoRefreshInterval { get; set; }

                [NameInMap("AutoRefreshPolicy")]
                [Validation(Required=false)]
                public string AutoRefreshPolicy { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                [NameInMap("FsetDescription")]
                [Validation(Required=false)]
                public string FsetDescription { get; set; }

                [NameInMap("FsetId")]
                [Validation(Required=false)]
                public string FsetId { get; set; }

                [NameInMap("SourceSecurityType")]
                [Validation(Required=false)]
                public string SourceSecurityType { get; set; }

                [NameInMap("SourceStorage")]
                [Validation(Required=false)]
                public string SourceStorage { get; set; }

                /// <summary>
                /// <para>源端存储内的访问路径。</para>
                /// </summary>
                [NameInMap("SourceStoragePath")]
                [Validation(Required=false)]
                public string SourceStoragePath { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public long? Throughput { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF518948****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
