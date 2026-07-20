// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class RemoveProjectManagerRequest : TeaModel {
        [NameInMap("org_entities")]
        [Validation(Required=false)]
        public List<RemoveProjectManagerRequestOrgEntities> OrgEntities { get; set; }
        public class RemoveProjectManagerRequestOrgEntities : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>projectabc</para>
        /// </summary>
        [NameInMap("out_project_id")]
        [Validation(Required=false)]
        public string OutProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("project_id")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("remove_all")]
        [Validation(Required=false)]
        public bool? RemoveAll { get; set; }

    }

}
