// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpdateSupabaseVersionRequest : TeaModel {
        /// <summary>
        /// <para>The target minor version. You can query the supported upgrade versions for the current project by calling GetSupabaseUpdateVersion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240731</para>
        /// </summary>
        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        /// <summary>
        /// <para>The ID of the Supabase project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spb-xxxx</para>
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
