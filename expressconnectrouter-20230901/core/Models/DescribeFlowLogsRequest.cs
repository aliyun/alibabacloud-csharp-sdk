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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ECR ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-a5xqrgbeidz1w8****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The ID of the flow log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flowlog-jqnr0veifo5d****</para>
        /// </summary>
        [NameInMap("FlowLogId")]
        [Validation(Required=false)]
        public string FlowLogId { get; set; }

        /// <summary>
        /// <para>The flow log name. The name must be 0 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>same-flowlog</para>
        /// </summary>
        [NameInMap("FlowLogName")]
        [Validation(Required=false)]
        public string FlowLogName { get; set; }

        /// <summary>
        /// <para>The ID of the VBR associated with the ECR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-j6cwxhgg0s5nuephp****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The Logstore that stores the captured traffic data.</para>
        /// <list type="bullet">
        /// <item><description>If a Logstore is already created in the selected region, enter the name of the Logstore.</description></item>
        /// <item><description>If no Logstores are created in the selected region, enter a name and the system automatically creates a Logstore. The name of the Logstore. The name must meet the following requirements:</description></item>
        /// <item><description>The name must be unique in a project.</description></item>
        /// <item><description>It can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of NextToken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABkWw*******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The project that stores the captured traffic data.</para>
        /// <list type="bullet">
        /// <item><description>If a project is already created in the selected region, enter the name of the project.</description></item>
        /// <item><description>If no projects are created in the selected region, enter a name and the system automatically creates a project.</description></item>
        /// </list>
        /// <para>The project name must be unique in a region. You cannot change the name after the project is created. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be globally unique.</description></item>
        /// <item><description>The name can contain only lowercase letters,</description></item>
        /// <item><description>digits, and hyphens (-).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeFlowLogsRequestTag> Tag { get; set; }
        public class DescribeFlowLogsRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
