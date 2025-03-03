// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPolicyAttachmentsForTargetRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want to return the descriptions of the access control policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN (default value): Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is valid only for system access control policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The ID of the object whose access control policies you want to query. Access control policies can be attached to the following objects:</para>
        /// <list type="bullet">
        /// <item><description>Root folder</description></item>
        /// <item><description>Subfolders of the Root folder</description></item>
        /// <item><description>Members</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-ZDNPiT****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
