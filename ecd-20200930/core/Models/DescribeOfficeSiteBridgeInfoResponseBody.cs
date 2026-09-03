// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeOfficeSiteBridgeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The virtual bridge information.</para>
        /// </summary>
        [NameInMap("Bridge")]
        [Validation(Required=false)]
        public DescribeOfficeSiteBridgeInfoResponseBodyBridge Bridge { get; set; }
        public class DescribeOfficeSiteBridgeInfoResponseBodyBridge : TeaModel {
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
            /// <para>vb-sofiahfish***</para>
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
            /// <para>unsr</para>
            /// </summary>
            [NameInMap("BridgeType")]
            [Validation(Required=false)]
            public string BridgeType { get; set; }

            /// <summary>
            /// <para>The default password for the administrator page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("DefaultPassword")]
            [Validation(Required=false)]
            public string DefaultPassword { get; set; }

            /// <summary>
            /// <para>The default account for the administrator page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("DefaultUser")]
            [Validation(Required=false)]
            public string DefaultUser { get; set; }

            /// <summary>
            /// <para>The deployment time of the virtual bridge. The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-07T02:02:00Z</para>
            /// </summary>
            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public string DeployTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the virtual bridge. The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-18T00:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The public network address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://8.*.*.*:8080">http://8.*.*.*:8080</a></para>
            /// </summary>
            [NameInMap("InternetUrl")]
            [Validation(Required=false)]
            public string InternetUrl { get; set; }

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
            /// <para>The ID of the locked convenience office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing+dir-0211574032</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The office network name. The name must be 2 to 255 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter or Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P0801-1</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The start time of the virtual bridge. The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-07T02:02:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7E4322D-D679-5ACB-A909-490D2F0E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
