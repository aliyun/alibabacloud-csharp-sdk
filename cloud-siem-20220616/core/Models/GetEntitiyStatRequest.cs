// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetEntitiyStatRequest : TeaModel {
        /// <summary>
        /// <para>The asset ID associated with the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("AssetName")]
        [Validation(Required=false)]
        public string AssetName { get; set; }

        /// <summary>
        /// <para>The asset ID associated with the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("AssetUuid")]
        [Validation(Required=false)]
        public string AssetUuid { get; set; }

        /// <summary>
        /// <para>The asset ID associated with the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// <para>The asset ID associated with the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The asset ID associated with the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("EntityUuid")]
        [Validation(Required=false)]
        public string EntityUuid { get; set; }

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
        /// <para>The asset ID associated with the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("IsAsset")]
        [Validation(Required=false)]
        public string IsAsset { get; set; }

        /// <summary>
        /// <para>The sort order of the incident list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order.</description></item>
        /// <item><description>asc: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("IsMalwareEntity")]
        [Validation(Required=false)]
        public string IsMalwareEntity { get; set; }

        /// <summary>
        /// <para>The region where the threat detection and response data management center resides. Select the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: the asset belongs to the Chinese mainland or Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: the asset belongs to a region outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637941677243702</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: single-account logon.</description></item>
        /// <item><description>1: global view.</description></item>
        /// <item><description>2: switched view.</description></item>
        /// <item><description>3: partial view.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The entity tags. The value is a JSON array string in the following format: \&quot;[{\&quot;tagKey1\&quot;:\&quot;tagValue1\&quot;},{\&quot;tagKey2\&quot;:\&quot;tagValue2\&quot;}]\&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys:agent:dispose</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
