// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The compute resource type of the ResourceGroup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ComputingResourceProvider")]
        [Validation(Required=false)]
        public string ComputingResourceProvider { get; set; }

        /// <summary>
        /// <para>The description of the ResourceGroup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_api_report</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the ResourceGroup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testResourceGroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The resource type list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ecs: general computing resources</description></item>
        /// <item><description>Lingjun: Lingjun AI Compute resources</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags to add, containing up to 20 entries.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateResourceGroupRequestTag> Tag { get; set; }
        public class CreateResourceGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. The value of N ranges from 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. The value of N ranges from 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The VPC peering information of the ResourceGroup.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        /// <summary>
        /// <para>The resource group version. This parameter only takes effect when the resource type is ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
