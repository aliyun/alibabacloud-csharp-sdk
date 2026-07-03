// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page. The value must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The entity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host1****</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// <para>The entity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ip: IP address</description></item>
        /// <item><description>domain: domain name</description></item>
        /// <item><description>url: URL</description></item>
        /// <item><description>process: process</description></item>
        /// <item><description>file: file</description></item>
        /// <item><description>host: host</description></item>
        /// <item><description>cloud_account: cloud account</description></item>
        /// <item><description>container: container</description></item>
        /// <item><description>bucket: Object Storage Service (OSS) bucket.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The entity UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("EntityUuid")]
        [Validation(Required=false)]
        public string EntityUuid { get; set; }

        /// <summary>
        /// <para>The list of entity UUIDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****,6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("EntityUuids")]
        [Validation(Required=false)]
        public string EntityUuids { get; set; }

        /// <summary>
        /// <para>The incident ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>Specifies whether the entity is malicious. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No.</description></item>
        /// <item><description>1: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsMalwareEntity")]
        [Validation(Required=false)]
        public string IsMalwareEntity { get; set; }

        /// <summary>
        /// <para>The malicious entity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun.siem.sas.alert_tag.miner_software</para>
        /// </summary>
        [NameInMap("MalwareType")]
        [Validation(Required=false)]
        public string MalwareType { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the data management center of the threat analysis feature resides. Select the region based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: the assets reside in the Chinese mainland or Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: the assets reside in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: the view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The entity tags. The value is a JSON array string:</para>
        /// <para><c>&quot;[{&quot;tagKey1&quot;:&quot;tagValue1&quot;},{&quot;tagKey2&quot;:&quot;tagValue2&quot;}]&quot;</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;tagKey1&quot;:&quot;tagValue1&quot;},{&quot;tagKey2&quot;:&quot;tagValue2&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
