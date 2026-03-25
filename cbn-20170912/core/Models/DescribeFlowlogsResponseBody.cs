// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeFlowlogsResponseBody : TeaModel {
        [NameInMap("FlowLogs")]
        [Validation(Required=false)]
        public DescribeFlowlogsResponseBodyFlowLogs FlowLogs { get; set; }
        public class DescribeFlowlogsResponseBodyFlowLogs : TeaModel {
            [NameInMap("FlowLog")]
            [Validation(Required=false)]
            public List<DescribeFlowlogsResponseBodyFlowLogsFlowLog> FlowLog { get; set; }
            public class DescribeFlowlogsResponseBodyFlowLogsFlowLog : TeaModel {
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FlowLogId")]
                [Validation(Required=false)]
                public string FlowLogId { get; set; }

                [NameInMap("FlowLogName")]
                [Validation(Required=false)]
                public string FlowLogName { get; set; }

                [NameInMap("FlowLogVersion")]
                [Validation(Required=false)]
                public string FlowLogVersion { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                [NameInMap("LogFormatString")]
                [Validation(Required=false)]
                public string LogFormatString { get; set; }

                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeFlowlogsResponseBodyFlowLogsFlowLogTags Tags { get; set; }
                public class DescribeFlowlogsResponseBodyFlowLogsFlowLogTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeFlowlogsResponseBodyFlowLogsFlowLogTagsTag> Tag { get; set; }
                    public class DescribeFlowlogsResponseBodyFlowLogsFlowLogTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TransitRouterAttachmentId")]
                [Validation(Required=false)]
                public string TransitRouterAttachmentId { get; set; }

                [NameInMap("TransitRouterId")]
                [Validation(Required=false)]
                public string TransitRouterId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7DDDC17-FA06-4AC2-8F35-59D2470FCFC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
