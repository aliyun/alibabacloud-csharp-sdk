// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopIdsByVulNamesRequest : TeaModel {
        /// <summary>
        /// <para>The necessity level for vulnerability fixing, which indicates the urgency of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asap: high</description></item>
        /// <item><description>later: medium</description></item>
        /// <item><description>nntf: low</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap</para>
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
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

        /// <summary>
        /// <para>The vulnerability type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cve: Linux software vulnerability</description></item>
        /// <item><description>sys: Windows system vulnerability</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The array of vulnerability names.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VulName")]
        [Validation(Required=false)]
        public List<string> VulName { get; set; }

    }

}
