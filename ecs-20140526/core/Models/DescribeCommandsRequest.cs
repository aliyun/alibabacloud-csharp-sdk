// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCommandsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz01272yr52****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The encoding format for the <c>CommandContent</c> and <c>Output</c> values in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PlainText: returns the raw script content and output.</para>
        /// </description></item>
        /// <item><description><para>Base64: returns the Base64-encoded script content and output.</para>
        /// </description></item>
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
        /// <item><description><para>If you specify the <c>Provider</c> parameter to query public commands, fuzzy search is supported by default.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify the <c>Provider</c> parameter to query private commands, fuzzy search is supported. You can use an asterisk (\*) as a wildcard. For example, <c>test*</c> returns all commands whose descriptions start with <c>test</c>, <c>*test</c> returns all commands whose descriptions end with <c>test</c>, and <c>*test*</c> returns all commands whose descriptions contain <c>test</c>.</para>
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
        /// <para>Specifies whether to return only the latest version of public commands. This parameter does not affect private commands.</para>
        /// <list type="bullet">
        /// <item><description><para>true: returns only the latest version of public commands.</para>
        /// </description></item>
        /// <item><description><para>false: returns all versions of public commands.</para>
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
        /// <para>The maximum number of entries to return per page.</para>
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
        /// <item><description><para>If you specify the <c>Provider</c> parameter to query public commands, fuzzy search is supported by default.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify the <c>Provider</c> parameter to query private commands, fuzzy search is supported. You can use an asterisk (\*) as a wildcard. For example, <c>command*</c> returns all commands whose names start with <c>command</c>, <c>*command</c> returns all commands whose names end with <c>command</c>, and <c>*command*</c> returns all commands whose names contain <c>command</c>.</para>
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
        /// <para>The pagination token for the next page of results. To retrieve the next page, set this parameter to the <c>NextToken</c> value from a previous call.</para>
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
        /// <para>This parameter is being deprecated. We recommend using NextToken and MaxResults for pagination instead.</para>
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
        /// <para>This parameter is being deprecated. We recommend using NextToken and MaxResults for pagination instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The provider of the public command.</para>
        /// <list type="bullet">
        /// <item><description><para>If you omit this parameter, the operation queries your private commands by default.</para>
        /// </description></item>
        /// <item><description><para>Set this parameter to <c>AlibabaCloud</c> to query all public commands from Alibaba Cloud.</para>
        /// </description></item>
        /// <item><description><para>If you set the value to a specific provider, the public commands from that provider are queried. For example:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>Provider</c> to <c>AlibabaCloud.ECS.GuestOS</c>, the public commands provided by AlibabaCloud.ECS.GuestOS are queried.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>Provider</c> to <c>AlibabaCloud.ECS.GuestOSDiagnose</c>, the public commands provided by AlibabaCloud.ECS.GuestOSDiagnose are queried.</para>
        /// </description></item>
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
        /// <para>The ID of the region. To view the latest list of regions, call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation.</para>
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
        /// <para>The tags used to filter commands.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCommandsRequestTag> Tag { get; set; }
        public class DescribeCommandsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. You can specify up to 20 tags. The tag key cannot be an empty string.</para>
            /// <para>A query can return a maximum of 1,000 resources that match the specified tags. If more than 1,000 resources match, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query all matching resources.</para>
            /// <para>The key can be up to 64 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. You can specify up to 20 tags. The tag value can be an empty string.</para>
            /// <para>The value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RunBatScript: A Bat script for Windows instances.</para>
        /// </description></item>
        /// <item><description><para>RunPowerShellScript: A PowerShell script for Windows instances.</para>
        /// </description></item>
        /// <item><description><para>RunShellScript: A Shell script for Linux instances.</para>
        /// </description></item>
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
