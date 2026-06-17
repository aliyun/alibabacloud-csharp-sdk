// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifySupabaseProjectDescriptionRequest : TeaModel {
        /// <summary>
        /// <para>The detailed description of the Supabase project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for-test-project</para>
        /// </summary>
        [NameInMap("ProjectDescription")]
        [Validation(Required=false)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// <para>The Supabase instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbp-twmoe9bakow</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
