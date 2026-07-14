// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifySupabaseAutoScalePolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable <b>automatic start and stop</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled. After this feature is enabled, Supabase automatically pauses and resumes based on traffic conditions.</description></item>
        /// <item><description>false: Disabled. After this feature is disabled, the automatic start and stop feature of Supabase is turned off.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoScale")]
        [Validation(Required=false)]
        public bool? AutoScale { get; set; }

        /// <summary>
        /// <para>The ID of the Supabase project. You can obtain the workspace ID from the Supabase page in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbp-tyarplz****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
