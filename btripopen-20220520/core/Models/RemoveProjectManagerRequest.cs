// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class RemoveProjectManagerRequest : TeaModel {
        /// <summary>
        /// <para>The list of manager group entities to delete. This parameter can be left empty when removeAll is set to true.</para>
        /// </summary>
        [NameInMap("org_entities")]
        [Validation(Required=false)]
        public List<RemoveProjectManagerRequestOrgEntities> OrgEntities { get; set; }
        public class RemoveProjectManagerRequestOrgEntities : TeaModel {
            /// <summary>
            /// <para>The employee ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>Required. Only &quot;1&quot; (employee) is supported in the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// <para>The third-party project ID. You must specify at least one of out_project_id and projectId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>projectabc</para>
        /// </summary>
        [NameInMap("out_project_id")]
        [Validation(Required=false)]
        public string OutProjectId { get; set; }

        /// <summary>
        /// <para>The internal project ID. You must specify at least one of project_id and outProjectId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("project_id")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove all managers from the project. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("remove_all")]
        [Validation(Required=false)]
        public bool? RemoveAll { get; set; }

    }

}
