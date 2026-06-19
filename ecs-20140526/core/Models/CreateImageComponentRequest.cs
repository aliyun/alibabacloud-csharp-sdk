// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImageComponentRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The value of <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The component type. Image build components and test components are supported.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Build</description></item>
        /// <item><description>Test</description></item>
        /// </list>
        /// <para>Default value: Build.</para>
        /// <remarks>
        /// <para>Build components can be used only in build templates. Test components can be used only in test templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Build</para>
        /// </summary>
        [NameInMap("ComponentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        /// <summary>
        /// <para>The version number of the component, which is used together with the component name. The format is major.minor.patch, and all values are non-negative integers.</para>
        /// <para>Default value: (x+1).0.0, where x is the current maximum major version number of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ComponentVersion")]
        [Validation(Required=false)]
        public string ComponentVersion { get; set; }

        /// <summary>
        /// <para>The component content, which consists of multiple commands. The content cannot exceed 16 KB. For more information about supported commands and command formats, see <a href="https://help.aliyun.com/document_detail/200206.html">Commands supported by Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tasks:</para>
        /// <list type="bullet">
        /// <item><description>Name: HelloWorld
        /// Action: RunShellCommand
        /// Properties:
        ///   commandContent: echo hello world</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The description. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The component name. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. The name cannot start with http:// or https://. The name can contain letters, Chinese characters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para>If you do not specify Name, the ImageComponentId return value is used by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testComponent</para>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
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
        /// <para>The operating system supported by the component.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Linux</description></item>
        /// <item><description>Windows</description></item>
        /// </list>
        /// <para>Default value: Linux.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public string SystemType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImageComponentRequestTag> Tag { get; set; }
        public class CreateImageComponentRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. The tag key cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with acs:. The tag value cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
