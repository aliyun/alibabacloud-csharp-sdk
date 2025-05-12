// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListElasticNetworkInterfacesRequest : TeaModel {
        /// <summary>
        /// <para>Lingjun Elastic Network Interface ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>leni-1234****</para>
        /// </summary>
        [NameInMap("ElasticNetworkInterfaceId")]
        [Validation(Required=false)]
        public string ElasticNetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The IP address of the BE cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.1</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The network type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Tenant: Tenant.</description></item>
        /// <item><description>VPC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tenant</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-lbj3aej****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the enterprise-level snapshot policy.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Create Failed: the creation failure.</description></item>
        /// <item><description>Delete Failed: the that failed to be deleted.</description></item>
        /// <item><description>Executing</description></item>
        /// <item><description>Available: The template is available.</description></item>
        /// <item><description>Deleting</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListElasticNetworkInterfacesRequestTag> Tag { get; set; }
        public class ListElasticNetworkInterfacesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the variable.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CUSTOM: custom type.</description></item>
        /// <item><description>DEFAULT: system type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6u8473r84e9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6aa4ddo97fr****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
