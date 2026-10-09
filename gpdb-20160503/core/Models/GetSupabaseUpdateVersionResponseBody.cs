// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSupabaseUpdateVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The latest upgradable version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240731</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// <para>The ID of the Supabase project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spb-xxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The recommended stable version for upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240630</para>
        /// </summary>
        [NameInMap("StableVersion")]
        [Validation(Required=false)]
        public string StableVersion { get; set; }

    }

}
