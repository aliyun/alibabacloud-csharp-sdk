// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetSpMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The workspace ID. This parameter is the same as <c>OfficeSiteId</c>. We recommend that you use <c>OfficeSiteId</c> to replace <c>DirectoryId</c>. You can specify only <c>DirectoryId</c> or <c>OfficeSiteId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-400695****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-400695****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
