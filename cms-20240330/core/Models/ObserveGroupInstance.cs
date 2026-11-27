// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupInstance : TeaModel {
        /// <summary>
        /// <para>The entity category adapted from entityType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The key-value pairs of the monitoring dimensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;1234567890123456&quot;,&quot;instanceId&quot;:&quot;i-bp1gj8wyq4fxk28k6iy2&quot;}</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Dimension { get; set; }

        /// <summary>
        /// <para>The entity domain, such as acs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        /// <summary>
        /// <para>The UModel entity ID, which corresponds to the <b>entity_id</b> field of the entity and identifies a member of the observation group together with entityDomain and entityType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1gj8wyq4fxk28k6iy2</para>
        /// </summary>
        [NameInMap("entityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The role of the entity in the observation group. main indicates the primary entity directly matched by the management rule. related indicates the child entity managed through associations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("entityRole")]
        [Validation(Required=false)]
        public string EntityRole { get; set; }

        /// <summary>
        /// <para>The entity type, such as acs.ecs.instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs.ecs.instance</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The ID of the observation group to which the entity belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>og-845e0a26455f437c</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1gj8wyq4fxk28k6iy2</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-prod-01</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3gn5i6bigbi</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The key-value pairs of the instance tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;env&quot;:&quot;prod&quot;}</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>The UID of the user that owns the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
