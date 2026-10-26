// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserTagValueRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the tag to be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pop_001</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        /// <summary>
        /// <para>The tag value to be modified.</para>
        /// <list type="bullet">
        /// <item><description>To clear this tag, set the tag value to ($NULL$).</description></item>
        /// <item><description>For multiple values, use English commas to separate them.</description></item>
        /// <item><description>Format validation, maximum length: 3000 characters</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product Director</para>
        /// </summary>
        [NameInMap("TagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

        /// <summary>
        /// <para>The user ID for which the tag value is to be modified. This user ID refers to the Quick BI UserID, not the Alibaba Cloud UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
