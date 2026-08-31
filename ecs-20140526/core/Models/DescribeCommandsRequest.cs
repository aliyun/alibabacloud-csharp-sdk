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
        /// <para>The encoding mode of the <c>CommandContent</c> and <c>Output</c> fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: Returns the original script content and output.</description></item>
        /// <item><description>Base64: Returns the Base64-encoded script content and output.</description></item>
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
        /// <item><description><para>When the <c>Provider</c> parameter is specified parameter query public commands, fuzzy match is supported by default.</para>
        /// </description></item>
        /// <item><description><para>When the <c>Provider</c> parameter is not specified parameter query private commands, fuzzy match is supported. For example, enter <c>test*</c> to search for all commands whose descriptions start with <c>test</c>, enter <c>*test</c> to search for all commands whose descriptions end with <c>test</c>, or enter <c>*test*</c> to search for all commands whose descriptions contain <c>test</c>.</para>
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
        /// <para>Specifies whether to query only the latest version of public commands when the query results include public commands. This parameter does not affect the query of private commands.</para>
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
        /// <para>The maximum number of entries per page for a paged query.</para>
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
        /// <item><description><para>When the <c>Provider</c> parameter is specified parameter query public commands, fuzzy match is supported by default.</para>
        /// </description></item>
        /// <item><description><para>When the <c>Provider</c> parameter is not specified parameter query private commands, fuzzy match is supported. For example, enter <c>command*</c> to search for all commands whose names start with <c>command</c>, enter <c>*command</c> to search for all commands whose names end with <c>command</c>, or enter <c>*command*</c> to search for all commands whose names contain <c>command</c>.</para>
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
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous API call.</para>
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
        /// <para>This parameter is about to go offline. Use NextToken and MaxResults to complete paged query operations. For paging, use NextToken and MaxResults instead.</para>
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
        /// <para>This parameter is about to go offline. Use NextToken and MaxResults to complete paged query operations. For paging, use NextToken and MaxResults instead.</para>
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
        /// <item><description>If this parameter is not specified, all Cloud Assistant commands that you manually created are queried by default.</description></item>
        /// <item><description>If this parameter is set to <c>AlibabaCloud</c>, all public commands provided by Alibaba Cloud are queried.</description></item>
        /// <item><description>If this parameter is set to a specific public command provider, all public commands provided by that provider are queried. Examples:<list type="bullet">
        /// <item><description>If <c>Provider=AlibabaCloud.ECS.GuestOS</c>, public commands provided by <c>AlibabaCloud.ECS.GuestOS</c> are queried.</description></item>
        /// <item><description>If <c>Provider=AlibabaCloud.ECS.GuestOSDiagnose</c>, public commands provided by <c>AlibabaCloud.ECS.GuestOSDiagnose</c> are queried.</description></item>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCommandsRequestTag> Tag { get; set; }
        public class DescribeCommandsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the resource count with this tag cannot exceed 1,000. If you use multiple tags to filter resources, the resource count with all specified tags attached cannot exceed 1,000. If the resource count exceeds 1,000, use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query resources.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description>RunBatScript: Bat script that runs on Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell script that runs on Windows instances.</description></item>
        /// <item><description>RunShellScript: Shell script that runs on Linux instances.</description></item>
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
