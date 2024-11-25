// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The keyword of the zone name. The value is not case-sensitive. You can set SearchMode to LIKE or EXACT. The default value of SearchMode is LIKE.</para>
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
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
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
        /// <para>The number of entries per page. Valid values: <b>1 to 100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the virtual private cloud (VPC) associated with the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("QueryRegionId")]
        [Validation(Required=false)]
        public string QueryRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC associated with the zone.</para>
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
        /// <para>The tags added to the zone.</para>
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<DescribeZonesRequestResourceTag> ResourceTag { get; set; }
        public class DescribeZonesRequestResourceTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N added to the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N added to the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>daily</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The search mode. The value of Keyword is the search scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LIKE</b> (default): fuzzy search</description></item>
        /// <item><description><b>EXACT</b>: exact search</description></item>
        /// </list>
        /// <para>Default value: <b>LIKE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIKE</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The types of cloud services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BLINK</para>
        /// </summary>
        [NameInMap("ZoneTag")]
        [Validation(Required=false)]
        public List<string> ZoneTag { get; set; }

        /// <summary>
        /// <para>The zone type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AUTH_ZONE</b>: authoritative zone</description></item>
        /// <item><description><b>CLOUD_PRODUCT_ZONE</b>: authoritative zone for cloud services</description></item>
        /// </list>
        /// <para>Default value: <b>AUTH_ZONE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD_PRODUCT_ZONE</para>
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
