// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EntityGroupBase : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eg-1234567890</para>
        /// </summary>
        [NameInMap("entityGroupId")]
        [Validation(Required=false)]
        public string EntityGroupId { get; set; }

        [NameInMap("entityGroupName")]
        [Validation(Required=false)]
        public string EntityGroupName { get; set; }

        [NameInMap("entityQueries")]
        [Validation(Required=false)]
        public List<EntityGroupBaseEntityQueries> EntityQueries { get; set; }
        public class EntityGroupBaseEntityQueries : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acs.ecs.instance</para>
            /// </summary>
            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>.entity with(type=\&quot;acs.ecs.instance\&quot;) | where region_id in (\&quot;cn-beijing\&quot;)</para>
            /// </summary>
            [NameInMap("spl")]
            [Validation(Required=false)]
            public string Spl { get; set; }

        }

        [NameInMap("entityRules")]
        [Validation(Required=false)]
        public EntityDiscoverRule EntityRules { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-heyuan</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1654218***343050</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default-cms-1654218***343050-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
