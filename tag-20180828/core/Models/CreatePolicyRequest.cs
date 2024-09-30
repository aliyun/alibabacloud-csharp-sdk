// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class CreatePolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): performs a dry run and performs the actual request.</description></item>
        /// <item><description>true: performs only a dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The document of the tag policy.</para>
        /// <para>For more information about the syntax of a tag policy, see <a href="https://help.aliyun.com/document_detail/417436.html">Syntax of a tag policy</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tags&quot;:{&quot;CostCenter&quot;:{&quot;tag_value&quot;:{&quot;@@assign&quot;:[&quot;Beijing&quot;,&quot;Shanghai&quot;]},&quot;tag_key&quot;:{&quot;@@assign&quot;:&quot;CostCenter&quot;}}}}</para>
        /// </summary>
        [NameInMap("PolicyContent")]
        [Validation(Required=false)]
        public string PolicyContent { get; set; }

        /// <summary>
        /// <para>The description of the tag policy.</para>
        /// <para>The description must be 0 to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a tag policy example.</para>
        /// </summary>
        [NameInMap("PolicyDesc")]
        [Validation(Required=false)]
        public string PolicyDesc { get; set; }

        /// <summary>
        /// <para>The name of the tag policy.</para>
        /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-shanghai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The mode of the Tag Policy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: single-account mode. Set the value to USER if you use an Alibaba Cloud account or a member of a resource directory to call this API operation to create a tag policy for the Alibaba Cloud account or member.</description></item>
        /// <item><description>RD: multi-account mode. Set the value to RD if you use the management account of a resource directory to call this API operation to create a tag policy for the resource directory.</description></item>
        /// </list>
        /// <para>For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RD</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
