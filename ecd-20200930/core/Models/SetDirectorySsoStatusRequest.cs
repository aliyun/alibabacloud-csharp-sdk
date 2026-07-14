// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetDirectorySsoStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AD office network.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-h95efs1mbukd9****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable single sign-on (SSO). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables SSO</description></item>
        /// <item><description>false: disables SSO.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSso")]
        [Validation(Required=false)]
        public bool? EnableSso { get; set; }

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
