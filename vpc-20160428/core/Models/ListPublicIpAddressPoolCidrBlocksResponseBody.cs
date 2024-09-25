// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolCidrBlocksResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> was not returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value is the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// </summary>
        [NameInMap("PublicIpPoolCidrBlockList")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolCidrBlocksResponseBodyPublicIpPoolCidrBlockList> PublicIpPoolCidrBlockList { get; set; }
        public class ListPublicIpAddressPoolCidrBlocksResponseBodyPublicIpPoolCidrBlockList : TeaModel {
            /// <summary>
            /// <para>The ID of the IP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The CIDR blocks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-10T01:37:38Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The information about the CIDR blocks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pippool-6wetvn6fumkgycssx****</para>
            /// </summary>
            [NameInMap("PublicIpAddressPoolId")]
            [Validation(Required=false)]
            public string PublicIpAddressPoolId { get; set; }

            /// <summary>
            /// <para>The time when the CIDR block was created. The time is displayed in <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of available IP addresses in the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalIpNum")]
            [Validation(Required=false)]
            public int? TotalIpNum { get; set; }

            /// <summary>
            /// <para>The status of the CIDR block in the IP address pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b>: available</description></item>
            /// <item><description><b>Deleting</b>: being deleted</description></item>
            /// <item><description><b>Modifying</b>: being modified</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("UsedIpNum")]
            [Validation(Required=false)]
            public int? UsedIpNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned. Valid values: <b>10</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
