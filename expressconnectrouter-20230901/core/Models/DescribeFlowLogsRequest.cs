// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeFlowLogsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only perform a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: send a check request and do not modify service resources.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): send a normal request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the Express Connect Router (ECR).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-a5xqrgbeidz1w8****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The instance ID of the flow log instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-flog-jqnr0veifo5d****</para>
        /// </summary>
        [NameInMap("FlowLogId")]
        [Validation(Required=false)]
        public string FlowLogId { get; set; }

        /// <summary>
        /// <para>The name of the flow log. The name must be 0 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>same-flowlog</para>
        /// </summary>
        [NameInMap("FlowLogName")]
        [Validation(Required=false)]
        public string FlowLogName { get; set; }

        /// <summary>
        /// <para>The instance ID of the VBR instance loaded on the Express Connect Router (ECR).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-j6cwxhgg0s5nuephp****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The Simple Log Service Logstore used to capture traffic.</para>
        /// <list type="bullet">
        /// <item><description><para>If you have created a Logstore in the current region, you can enter the name of the existing Logstore.</para>
        /// </description></item>
        /// <item><description><para>If you have not created a Logstore in the current region, you can specify a custom name for the Logstore, and the system automatically creates the Logstore. The naming rules are as follows:</para>
        /// </description></item>
        /// <item><description><para>The Logstore name must be unique within the same project.</para>
        /// </description></item>
        /// <item><description><para>It can contain only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>It must be 3 to 63 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 1 to 2147483647. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, no next query is available.</description></item>
        /// <item><description>If NextToken has a return value, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABkWw*******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The Simple Log Service project used to capture traffic.</para>
        /// <list type="bullet">
        /// <item><description>If you have created a project in the current region, you can enter the name of the existing project.</description></item>
        /// <item><description>If you have not created a project in the current region, you can specify a custom name for the project, and the system automatically creates the project.</description></item>
        /// </list>
        /// <para>The project name must be globally unique within an Alibaba Cloud region and cannot be modified after creation. The naming rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description>The project name must be globally unique.</description></item>
        /// <item><description>It can contain only lowercase</description></item>
        /// <item><description>letters, digits, and hyphens (-).</description></item>
        /// <item><description>It must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>It must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the flow log instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2aq7f4va****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <para>You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeFlowLogsRequestTag> Tag { get; set; }
        public class DescribeFlowLogsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20. If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
