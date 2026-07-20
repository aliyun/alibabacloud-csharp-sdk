// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddProjectManagerRequest : TeaModel {
        /// <summary>
        /// <para>The list of manager group entities. Currently, entityType only supports &quot;1&quot; (employee). The maximum number is 10.</para>
        /// </summary>
        [NameInMap("org_entities")]
        [Validation(Required=false)]
        public List<AddProjectManagerRequestOrgEntities> OrgEntities { get; set; }
        public class AddProjectManagerRequestOrgEntities : TeaModel {
            /// <summary>
            /// <para>The employee ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>Required. Currently only supports &quot;1&quot; (employee).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// <para>The third-party project ID. You must specify at least one of project_id and out_project_id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>projectabc</para>
        /// </summary>
        [NameInMap("out_project_id")]
        [Validation(Required=false)]
        public string OutProjectId { get; set; }

        /// <summary>
        /// <para>The internal project ID. You must specify at least one of project_id and out_project_id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("project_id")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
