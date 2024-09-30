// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ModifyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: The system performs the related operation based on the parameter settings in the request. This is the default value.</description></item>
        /// <item><description>true: The system does not perform the related operation based on the parameter settings in the request but only verifies the parameter settings.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tags&quot;:{&quot;CostCenter&quot;:{&quot;tag_value&quot;:{&quot;@@assign&quot;:[&quot;Beijing&quot;,&quot;Shanghai&quot;]},&quot;tag_key&quot;:{&quot;@@assign&quot;:&quot;CostCenter&quot;}}}}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
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
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("PolicyDesc")]
        [Validation(Required=false)]
        public string PolicyDesc { get; set; }

        /// <summary>
        /// <para>The ID of the tag policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-5732750813924f90****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The name of the tag policy.</para>
        /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
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

    }

}
