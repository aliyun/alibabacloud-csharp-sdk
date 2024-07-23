// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that is used to start the next query. If this parameter is empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The office network information.</para>
        /// </summary>
        [NameInMap("OfficeSiteOverviewResults")]
        [Validation(Required=false)]
        public List<ListOfficeSiteOverviewResponseBodyOfficeSiteOverviewResults> OfficeSiteOverviewResults { get; set; }
        public class ListOfficeSiteOverviewResponseBodyOfficeSiteOverviewResults : TeaModel {
            /// <summary>
            /// <para>The number of expired cloud computers in the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HasExpiredEdsCount")]
            [Validation(Required=false)]
            public int? HasExpiredEdsCount { get; set; }

            /// <summary>
            /// <para>The number of expired cloud computers in the cloud computer pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HasExpiredEdsCountForGroup")]
            [Validation(Required=false)]
            public int? HasExpiredEdsCountForGroup { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The office network name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The office network status.</para>
            /// <para>Default values:</para>
            /// <list type="bullet">
            /// <item><description><para>CONFIGUSERFAILED</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>REGISTERING</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>REGISTERED</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>NEEDCONFIGTRUST</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>CONFIGUSERING</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>CONFIGTRUSTFAILED</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ERROR</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>CONFIGTRUSTING</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>NEEDCONFIGUSER</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGISTERED</para>
            /// </summary>
            [NameInMap("OfficeSiteStatus")]
            [Validation(Required=false)]
            public string OfficeSiteStatus { get; set; }

            /// <summary>
            /// <para>The ID of the region where the office network resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of cloud computers that are running in the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningEdsCount")]
            [Validation(Required=false)]
            public int? RunningEdsCount { get; set; }

            /// <summary>
            /// <para>The number of running cloud computers in the cloud computer pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningEdsCountForGroup")]
            [Validation(Required=false)]
            public int? RunningEdsCountForGroup { get; set; }

            /// <summary>
            /// <para>The total number of cloud computers in the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalEdsCount")]
            [Validation(Required=false)]
            public int? TotalEdsCount { get; set; }

            /// <summary>
            /// <para>The total number of cloud computers in the cloud computer pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalEdsCountForGroup")]
            [Validation(Required=false)]
            public int? TotalEdsCountForGroup { get; set; }

            /// <summary>
            /// <para>The office network type and its suitable VPC type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard (default): standard, exclusive VPC</description></item>
            /// <item><description>customized: custom, user VPC</description></item>
            /// <item><description>basic: basic, shared VPC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

            /// <summary>
            /// <para>The number of cloud computers that are about to expire in the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WillExpiredEdsCount")]
            [Validation(Required=false)]
            public int? WillExpiredEdsCount { get; set; }

            /// <summary>
            /// <para>The number of cloud computers that are about to expire in the cloud computer pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WillExpiredEdsCountForGroup")]
            [Validation(Required=false)]
            public int? WillExpiredEdsCountForGroup { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
