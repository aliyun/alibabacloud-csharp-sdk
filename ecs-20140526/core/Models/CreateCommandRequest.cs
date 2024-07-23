// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateCommandRequest : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded content of the command. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The value must be Base64-encoded and cannot exceed 18 KB in size.</para>
        /// </description></item>
        /// <item><description><para>You can use custom parameters in the command content. To enable the custom parameter feature, you must set <c>EnableParameter</c> to true.</para>
        /// <list type="bullet">
        /// <item><description>Custom parameters are defined in the <c>{{}}</c> format. Within <c>{{}}</c>, the spaces and line feeds before and after the parameter names are ignored.</description></item>
        /// <item><description>You can specify up to 20 custom parameters.</description></item>
        /// <item><description>A custom parameter name can contain only letters, digits, underscores (_), and hyphens (-). The name is case-insensitive. The ACS:: prefix cannot be used to specify non-built-in environment parameters.</description></item>
        /// <item><description>Each custom parameter name can be up to 64 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can specify built-in environment parameters as custom parameters in a command. When you run the command, Cloud Assistant automatically uses the environment parameter values for the custom parameters. You can specify the following built-in environment variables:</para>
        /// <list type="bullet">
        /// <item><description><para><c>{{ACS::RegionId}}</c>: the region ID.</para>
        /// </description></item>
        /// <item><description><para><c>{{ACS::AccountId}}</c>: the UID of the Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InstanceId}}</c>: the instance ID. If you want to run the command on multiple instances and specify <c>{{ACS::InstanceId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InstanceName}}</c>: the instance name. If you want to run the command on multiple instances and specify <c>{{ACS::InstanceName}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.344</description></item>
        /// <item><description>Windows: 2.1.3.344</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::InvokeId}}</c>: the ID of the task. If you want to specify <c>{{ACS::InvokeId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>{{ACS::CommandId}}</c>: the command ID. If you want to call the <a href="https://help.aliyun.com/document_detail/141751.html">RunCommand</a> operation to run the command and specify <c>{{ACS::CommandId}}</c> as a built-in environment parameter, make sure that the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
        /// <item><description>Linux: 2.2.3.309</description></item>
        /// <item><description>Windows: 2.1.3.309</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyAxMjM=</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The encoding mode of the command content (CommandContent). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: The command content is not encoded.</description></item>
        /// <item><description>Base64: The command content is Base64-encoded.</description></item>
        /// </list>
        /// <para>Default value: Base64.</para>
        /// <remarks>
        /// <para>If the specified value of this parameter is invalid, Base64 is used by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The description of the command. The description supports all character sets and can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to use custom parameters in the command.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The name of the command. The name supports all character sets and can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the command. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags to add to the command.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCommandRequestTag> Tag { get; set; }
        public class CreateCommandRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags, call <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
            /// <para>It can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>he maximum timeout period for the command execution on the instance. Unit: seconds. When a command that you created cannot be run, the command times out. When a command execution times out, Cloud Assistant Agent forcefully terminates the command process by canceling the PID. </para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The command type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript: batch commands. These commands are applicable to Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell commands. These commands are applicable to Windows instances.</description></item>
        /// <item><description>RunShellScript: shell commands. These commands are applicable to Linux instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RunShellScript</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The execution path of the command on ECS instances. The value can be up to 200 characters in length.</para>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>For Linux instance, the default value is the home directory of the root user, which is the <c>/root</c> directory.</description></item>
        /// <item><description>For Windows instances, the default value is the directory where the Cloud Assistant Agent process resides, such as <c>C:\\Windows\\System32\\</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set WorkingDir to a directory other than default ones, make sure that the directory exists on the instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/root/</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
