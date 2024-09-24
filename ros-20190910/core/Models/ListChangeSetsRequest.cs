// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListChangeSetsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the change set. If detailed information about the change set is not required, you can use this parameter to replace the GetChangeSet operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f6521a4-05af-4975-afe9-bc4b45ad****</para>
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// <para>The name of change set N. Maximum value of N: 5. You can use an asterisk (\*) as a wildcard for fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChangeSet</para>
        /// </summary>
        [NameInMap("ChangeSetName")]
        [Validation(Required=false)]
        public List<string> ChangeSetName { get; set; }

        /// <summary>
        /// <para>The execution status of change set N. Maximum value of N: 5. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UNAVAILABLE</description></item>
        /// <item><description>AVAILABLE</description></item>
        /// <item><description>EXECUTE_IN_PROGRESS</description></item>
        /// <item><description>EXECUTE_COMPLETE</description></item>
        /// <item><description>EXECUTE_FAILED</description></item>
        /// <item><description>OBSOLETE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("ExecutionStatus")]
        [Validation(Required=false)]
        public List<string> ExecutionStatus { get; set; }

        /// <summary>
        /// <para>The page number.\
        /// Pages start from page 1.\
        /// Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.\
        /// Valid values: 1 to 50.\
        /// Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the change set. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The status of change set N. Maximum value of N: 5. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATE_PENDING</description></item>
        /// <item><description>CREATE_IN_PROGRESS</description></item>
        /// <item><description>CREATE_COMPLETE</description></item>
        /// <item><description>CREATE_FAILED</description></item>
        /// <item><description>DELETE_FAILED</description></item>
        /// <item><description>DELETE_COMPLETE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_COMPLETE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
