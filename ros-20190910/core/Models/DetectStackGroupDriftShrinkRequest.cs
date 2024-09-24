// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DetectStackGroupDriftShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests.</para>
        /// <para>The value can be up to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The operation settings, in JSON format. The following fields are supported:</para>
        /// <list type="bullet">
        /// <item><description>FailureToleranceCount</description></item>
        /// </list>
        /// <para>The maximum number of stack group operation failures that can occur. In a stack group operation, if the total number of failures does not exceed the FailureToleranceCount value, the operation succeeds. Otherwise, the operation fails.</para>
        /// <para>If FailureToleranceCount is not specified, the default value 0 is used. You can specify one of FailureToleranceCount or FailureTolerancePercentage parameters, but you cannot specify both of them.</para>
        /// <para>Valid values: 0 to 20.</para>
        /// <list type="bullet">
        /// <item><description>FailureTolerancePercentage</description></item>
        /// </list>
        /// <para>The percentage of stack group operation failures that can occur. In a stack group operation, if the percentage of failures does not exceed the FailureTolerancePercentage value, the operation succeeds. Otherwise, the operation fails.</para>
        /// <para>You can specify one of FailureToleranceCount or FailureTolerancePercentage parameters, but you cannot specify both of them.</para>
        /// <para>Valid values: 0 to 100.</para>
        /// <list type="bullet">
        /// <item><description>MaxConcurrentCount</description></item>
        /// </list>
        /// <para>The maximum number of target accounts in which a drift detection operation can be performed at a time.</para>
        /// <para>You can specify one of MaxConcurrentCount or MaxConcurrentPercentage parameters, but you cannot specify both of them.</para>
        /// <para>Valid values: 1 to 20.</para>
        /// <list type="bullet">
        /// <item><description>MaxConcurrentPercentage</description></item>
        /// </list>
        /// <para>The maximum percentage of target accounts in which a drift detection operation can be performed at a time.</para>
        /// <para>You can specify one of MaxConcurrentCount or MaxConcurrentPercentage parameters, but you cannot specify both of them.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FailureToleranceCount&quot;: 1, &quot;MaxConcurrentCount&quot;: 2}</para>
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the stack group. You can call the <a href="~~131035#doc-api-ROS-DescribeRegions~~" title="Queries the DescribeRegions list of a region.">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique in a region.</para>
        /// <para>The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

    }

}
