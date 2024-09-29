// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want to return the description of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN (default value): Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only for system access control policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The ID of the access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-SImPt8GCEwiq****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
