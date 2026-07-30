// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListVirtualBridgesResponseBody : TeaModel {
        /// <summary>
        /// <para>The virtual bridge information.</para>
        /// </summary>
        [NameInMap("Bridges")]
        [Validation(Required=false)]
        public List<ListVirtualBridgesResponseBodyBridges> Bridges { get; set; }
        public class ListVirtualBridgesResponseBodyBridges : TeaModel {
            /// <summary>
            /// <para>The access type of the management page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The virtual bridge ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vb-sfijaosifiosjfoij***</para>
            /// </summary>
            [NameInMap("BridgeId")]
            [Validation(Required=false)]
            public string BridgeId { get; set; }

            /// <summary>
            /// <para>The virtual bridge specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vb.pro</para>
            /// </summary>
            [NameInMap("BridgeLevel")]
            [Validation(Required=false)]
            public string BridgeLevel { get; set; }

            /// <summary>
            /// <para>The virtual bridge status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inuse</para>
            /// </summary>
            [NameInMap("BridgeStatus")]
            [Validation(Required=false)]
            public string BridgeStatus { get; set; }

            /// <summary>
            /// <para>The third-party plugin type of the virtual bridge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>panbit</para>
            /// </summary>
            [NameInMap("BridgeType")]
            [Validation(Required=false)]
            public string BridgeType { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-07T02:02:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The internal network address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://10.0.0.0:8080">http://10.0.0.0:8080</a></para>
            /// </summary>
            [NameInMap("IntranetUrl")]
            [Validation(Required=false)]
            public string IntranetUrl { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen+dir-8485473914</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The office network name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hk11</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned. Valid values: 1 to 100. If this parameter is not specified, the default value 100 is used.
        /// The number of returned entries can be less than the specified value but cannot exceed it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
