// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The asset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("AssetName")]
        [Validation(Required=false)]
        public string AssetName { get; set; }

        /// <summary>
        /// <para>The asset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ip: IP address</para>
        /// </description></item>
        /// <item><description><para>domain: domain name</para>
        /// </description></item>
        /// <item><description><para>url: URL</para>
        /// </description></item>
        /// <item><description><para>process: process</para>
        /// </description></item>
        /// <item><description><para>file: file</para>
        /// </description></item>
        /// <item><description><para>host: host</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>The UUID of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456-2222-3333-5555-3435345****</para>
        /// </summary>
        [NameInMap("AssetUuid")]
        [Validation(Required=false)]
        public string AssetUuid { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The UUID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center of Threat Analysis is deployed. Select a region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: assets in the Chinese mainland or China (Hong Kong)</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: assets outside China</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member whose data you want to view. This parameter is available only when an administrator wants to switch to the perspective of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts that belong to the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
