// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCommandsRequest : TeaModel {
        /// <summary>
        /// <para>The command ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz01272yr52****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The encoding mode of the CommandContent and Output fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: Returns the original script content and output information.</description></item>
        /// <item><description>Base64: Returns the Base64-encoded script content and output information.</description></item>
        /// </list>
        /// <para>Default value: Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The description of the command.</para>
        /// <list type="bullet">
        /// <item><description><para>When you specify the Provider parameter parameter query public commands, fuzzy search is supported by default.</para>
        /// </description></item>
        /// <item><description><para>When you do not specify the Provider parameter parameter query private commands, fuzzy search is supported. For example, if you enter test*, the system searches for all commands whose descriptions start with test. If you enter *test, the system searches for all commands whose descriptions end with test. If you enter <em>test</em>, the system searches for all commands whose descriptions contain test.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only the latest version of public commands if the query result includes public commands. This parameter does not affect the query of private commands. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Queries only the latest version of public commands.</para>
        /// </description></item>
        /// <item><description><para>false: Queries all versions of public commands.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Latest")]
        [Validation(Required=false)]
        public bool? Latest { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for paging.</para>
        /// <para>Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the command.</para>
        /// <list type="bullet">
        /// <item><description><para>When you specify the Provider parameter parameter query public commands, fuzzy search is supported by default.</para>
        /// </description></item>
        /// <item><description><para>When you do not specify the Provider parameter parameter query private commands, fuzzy search is supported. For example, if you enter command*, the system searches for all commands whose names start with command. If you enter *command, the system searches for all commands whose names end with command. If you enter <em>command</em>, the system searches for all commands whose names contain command.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the NextToken value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be deprecated soon. Use the NextToken and MaxResults parameters for paging.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be deprecated soon. Use the NextToken and MaxResults parameters for paging.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The provider of the public command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the system queries all Cloud Assistant commands that you manually created by default.</description></item>
        /// <item><description>If you set this parameter to AlibabaCloud, the system queries all public commands provided by Alibaba Cloud.</description></item>
        /// <item><description>If you set this parameter to a specific public command provider, the system queries all public commands provided by the provider. Examples:<list type="bullet">
        /// <item><description>If you set this parameter to AlibabaCloud.ECS.GuestOS, the system queries the public commands provided by AlibabaCloud.ECS.GuestOS.</description></item>
        /// <item><description>If you set this parameter to AlibabaCloud.ECS.GuestOSDiagnose, the system queries the public commands provided by AlibabaCloud.ECS.GuestOSDiagnose.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AlibabaCloud</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the command belongs.</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCommandsRequestTag> Tag { get; set; }
        public class DescribeCommandsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command. Valid values of N: 1 to 20. The value cannot be an empty string.</para>
            /// <para>When you use a single tag to filter resources, the resource count for that tag cannot exceed 1,000. When you use multiple tags to filter resources, the resource count for resources attached to all the specified tags cannot exceed 1,000. If the resource count exceeds 1,000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command. Valid values of N: 1 to 20. The value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the command. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>RunBatScript: a Bat script that runs on a Windows instance.</description></item>
        /// <item><description>RunPowerShellScript: a PowerShell script that runs on a Windows instance.</description></item>
        /// <item><description>RunShellScript: a shell script that runs on a Linux instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunShellScript</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
