// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ConfigADConnectorTrustRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the enterprise AD office network.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-778418****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>Specifies whether to configure a trust password for the Remote Desktop Services (RDS) License Domain of the enterprise AD office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: configures a trust password for the RDS License Domain of the AD office network.</para>
        /// </description></item>
        /// <item><description><para>false: configures a trust password for a regular enterprise AD office network.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RdsLicenseDomain")]
        [Validation(Required=false)]
        public bool? RdsLicenseDomain { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The trust password. You can specify the password when you configure a trust relationship between the AD domain and the ecd.acs domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password123***</para>
        /// </summary>
        [NameInMap("TrustKey")]
        [Validation(Required=false)]
        public string TrustKey { get; set; }

    }

}
