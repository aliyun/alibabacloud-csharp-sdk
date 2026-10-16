// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPolicyAttachmentsForTargetRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the control policy descriptions are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN (default): Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// <item><description>ja: Japanese.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only for system control policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The target node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Root ID: queries the control policies attached to the Root node.</description></item>
        /// <item><description>Resource folder ID: queries the control policies attached to a resource folder.</description></item>
        /// <item><description>Member ID: queries the control policies attached to a member.</description></item>
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
