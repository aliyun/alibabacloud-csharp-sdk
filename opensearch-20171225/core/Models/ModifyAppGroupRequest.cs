// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifyAppGroupRequest : TeaModel {
        /// <summary>
        /// <para>The online version of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1223232</para>
        /// </summary>
        [NameInMap("currentVersion")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;test&quot;</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the industry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>general: general.</description></item>
        /// <item><description>ecommerce: e-commerce.</description></item>
        /// <item><description>education: education.</description></item>
        /// <item><description>esports: electronic sports.</description></item>
        /// <item><description>community: content community.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ecommerce&quot;</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to verify the application before modification. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
