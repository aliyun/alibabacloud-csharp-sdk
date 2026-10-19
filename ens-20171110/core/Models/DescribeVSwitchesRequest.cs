// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeVSwitchesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query vSwitches with IPv6 CIDR blocks enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries vSwitches with IPv6 CIDR blocks enabled in the specified region.</description></item>
        /// <item><description>false: Does not query vSwitches with IPv6 CIDR blocks enabled in the specified region.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the system queries all vSwitches by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The ENS edge zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xian-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The array of ENS edge zone IDs. Array length: 1 to 100.</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public List<string> EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the vSwitch to be queried belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-25cdvfeq58pl****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The page number of the list. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5m9xhlq8oh***</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The array of vSwitch IDs. Array length: 1 to 100.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The vSwitch name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testVSwitchName</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

    }

}
