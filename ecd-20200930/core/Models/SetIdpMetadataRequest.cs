// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetIdpMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The office network ID, which has the same meaning as <c>OfficeSiteId</c>. We recommend that you stop using <c>DirectoryId</c> and use <c>OfficeSiteId</c> instead. You can specify only one of <c>DirectoryId</c> and <c>OfficeSiteId</c>, not both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-400695****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The metadata of the identity provider (IdP).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&lt;EntityDescriptor ID********Descriptor&gt;</para>
        /// </summary>
        [NameInMap("IdpMetadata")]
        [Validation(Required=false)]
        public string IdpMetadata { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-400695****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
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
