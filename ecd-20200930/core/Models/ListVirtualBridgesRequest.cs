// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListVirtualBridgesRequest : TeaModel {
        /// <summary>
        /// <para>The list of virtual bridge IDs.</para>
        /// </summary>
        [NameInMap("BridgeId")]
        [Validation(Required=false)]
        public List<string> BridgeId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 1 to 500.
        /// Default value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query. An empty NextToken indicates that no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6mnFXZiT7NdvGNgkInJ****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// <remarks>
        /// <para>The <c>DirectoryId</c> parameter is deprecated. Use this parameter instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the list of regions supported by Elastic Desktop Service.</para>
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
