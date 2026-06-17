// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifySupabaseAutoScalePolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-scaling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables auto-scaling. The Supabase instance automatically pauses and resumes based on traffic.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables auto-scaling.</para>
        /// </description></item>
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
        /// <para>The ID of the Supabase project. To obtain the workspace ID, log in to the console and go to the Supabase page.</para>
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
