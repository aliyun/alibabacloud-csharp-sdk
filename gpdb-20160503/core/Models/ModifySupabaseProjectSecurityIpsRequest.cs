// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifySupabaseProjectSecurityIpsRequest : TeaModel {
        /// <summary>
        /// <para>The Supabase instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbp-407****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> to view available region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of IP addresses for the whitelist. Up to 1,000 IP addresses are supported. Separate multiple IP addresses with commas. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>10.23.12.24 (IP address)</para>
        /// </description></item>
        /// <item><description><para>10.23.12.24/24 (A CIDR block, where <c>/24</c> indicates the prefix length. The prefix length must be an integer in the range <c>[1,32]</c>.)</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the whitelist for database port 5432. The default value is true.</para>
        /// </summary>
        [NameInMap("UpdateDb")]
        [Validation(Required=false)]
        public bool? UpdateDb { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the whitelist for HTTP port 80 and HTTPS port 443. The default value is true.</para>
        /// </summary>
        [NameInMap("UpdateWeb")]
        [Validation(Required=false)]
        public bool? UpdateWeb { get; set; }

    }

}
