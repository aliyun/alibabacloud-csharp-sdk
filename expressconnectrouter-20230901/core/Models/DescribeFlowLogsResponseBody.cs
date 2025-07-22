// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeFlowLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried information about the request denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authentication is failed for ****</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed. For more information, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IllegalParamFormat.EcrId</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace the <c>%s</c> variable in <b>ErrMessage</b>.</para>
        /// <remarks>
        /// <para> For example, if the value of <b>ErrMessage</b> is <b>The Value of Input Parameter %s is not valid</b> and the value of <b>DynamicMessage</b> is <b>DtsJobId</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The param format of EcrId **** is illegal.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The information about the flow logs.</para>
        /// </summary>
        [NameInMap("FlowLogs")]
        [Validation(Required=false)]
        public List<DescribeFlowLogsResponseBodyFlowLogs> FlowLogs { get; set; }
        public class DescribeFlowLogsResponseBodyFlowLogs : TeaModel {
            /// <summary>
            /// <para>The time when the flow log was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-21T04:20Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the flow log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myFlowlog</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ECR ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-h4cop1khw98*****</para>
            /// </summary>
            [NameInMap("EcrId")]
            [Validation(Required=false)]
            public string EcrId { get; set; }

            /// <summary>
            /// <para>The ID of the flow log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flowlog-leypqehtgtia2*****</para>
            /// </summary>
            [NameInMap("FlowLogId")]
            [Validation(Required=false)]
            public string FlowLogId { get; set; }

            /// <summary>
            /// <para>The name of the flow log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myFlowlog</para>
            /// </summary>
            [NameInMap("FlowLogName")]
            [Validation(Required=false)]
            public string FlowLogName { get; set; }

            /// <summary>
            /// <para>The ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-9dpty76irpf4u15*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VBR</b>: virtual border router (VBR)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VBR</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The time window for collecting log data. Unit: seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>60</b></description></item>
            /// <item><description><b>600</b></description></item>
            /// </list>
            /// <para>Default value: <b>600</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The Logstore that stores the captured traffic data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FlowLogStore</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The name of the project that stores the captured traffic data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FlowLogProject</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The region ID of the flow log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the ECR belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzb3xwrexc4ry</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The sampling proportion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1:4096</b></description></item>
            /// <item><description><b>1:2048</b></description></item>
            /// <item><description><b>1:1024</b></description></item>
            /// </list>
            /// <para>Default value: <b>1:4096</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1:4096</para>
            /// </summary>
            [NameInMap("SamplingRate")]
            [Validation(Required=false)]
            public string SamplingRate { get; set; }

            /// <summary>
            /// <para>The ID of the region where Log Service is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SlsRegionId")]
            [Validation(Required=false)]
            public string SlsRegionId { get; set; }

            /// <summary>
            /// <para>The status of the flow log. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Active</b></para>
            /// </description></item>
            /// <item><description><para><b>Inactive</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag key.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeFlowLogsResponseBodyFlowLogsTags> Tags { get; set; }
            public class DescribeFlowLogsResponseBodyFlowLogsTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N of the instance. The tag key cannot be an empty string.</para>
                /// <remarks>
                /// <para>It can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>TagKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// <remarks>
                /// <para>It can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>. The tag value can be an empty string.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>TagValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The total number of entries returned. Valid values: 1 to 2147483647. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAYws9fJ0Ur4MGm/5OkDoW/Zn0J0/sCjivzwX9oBcwFnWaaas/kSG+J/WzLOxJHS4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FABF516-FED3-5697-BDA2-B18C5D9A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b></description></item>
        /// <item><description><b>False</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
