// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The keyword of the zone name. The search is not case-sensitive. You can set the SearchMode parameter to switch between exact search and fuzzy search. The default mode is fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC that is associated with the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("QueryRegionId")]
        [Validation(Required=false)]
        public string QueryRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC that is associated with the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-f8zvrvr1payllgz38****</para>
        /// </summary>
        [NameInMap("QueryVpcId")]
        [Validation(Required=false)]
        public string QueryVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the zone belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz2qj7awz****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource tags that are added to the zone.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<DescribeZonesRequestResourceTag> ResourceTag { get; set; }
        public class DescribeZonesRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The key of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>daily</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The search mode. This parameter takes effect only when the Keyword parameter is specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LIKE</b>: fuzzy search (default)</para>
        /// </description></item>
        /// <item><description><para><b>EXACT</b>: exact search</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>LIKE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXACT</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The list of cloud service types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BLINK</para>
        /// </summary>
        [NameInMap("ZoneTag")]
        [Validation(Required=false)]
        public List<string> ZoneTag { get; set; }

        /// <summary>
        /// <para>The type of the zones to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AUTH_ZONE</b>: authoritative zones.</para>
        /// </description></item>
        /// <item><description><para><b>CLOUD_PRODUCT_ZONE</b>: zones for cloud services.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>AUTH_ZONE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTH_ZONE</para>
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
