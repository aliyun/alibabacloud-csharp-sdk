// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenGeographicSpanRemainingBandwidthRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance to which the bandwidth plan is associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-nh98vzx8gfhlwn****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of one of the connected areas of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>China</b>: Chinese mainland</description></item>
        /// <item><description><b>North-America</b>: North America</description></item>
        /// <item><description><b>Asia-Pacific</b>: Asia Pacific</description></item>
        /// <item><description><b>Europe</b>: Europe</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China</para>
        /// </summary>
        [NameInMap("GeographicRegionAId")]
        [Validation(Required=false)]
        public string GeographicRegionAId { get; set; }

        /// <summary>
        /// <para>The ID of the other area connected by the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>China</b>: Chinese mainland</description></item>
        /// <item><description><b>North-America</b>: North America</description></item>
        /// <item><description><b>Asia-Pacific</b>: Asia Pacific</description></item>
        /// <item><description><b>Europe</b>: Europe</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>North-America</para>
        /// </summary>
        [NameInMap("GeographicRegionBId")]
        [Validation(Required=false)]
        public string GeographicRegionBId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
