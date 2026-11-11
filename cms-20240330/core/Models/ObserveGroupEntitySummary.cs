// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupEntitySummary : TeaModel {
        /// <summary>
        /// <para>The entity category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs</para>
        /// </summary>
        [NameInMap("entityCategory")]
        [Validation(Required=false)]
        public string EntityCategory { get; set; }

        /// <summary>
        /// <para>The total count of entities of this type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("entityCount")]
        [Validation(Required=false)]
        public int? EntityCount { get; set; }

        /// <summary>
        /// <para>The entity domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        /// <summary>
        /// <para>The entity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs.rocketmq.topic</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The count of primary entities of this type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("mainCount")]
        [Validation(Required=false)]
        public long? MainCount { get; set; }

        /// <summary>
        /// <para>The count of associated child entities of this type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("relatedCount")]
        [Validation(Required=false)]
        public long? RelatedCount { get; set; }

    }

}
