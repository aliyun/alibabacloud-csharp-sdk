// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetIdentityProviderSyncScopeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("EstimateStatus")]
        [Validation(Required=false)]
        public string EstimateStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("EstimatedUserCount")]
        [Validation(Required=false)]
        public long? EstimatedUserCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ExpandedDepartmentCount")]
        [Validation(Required=false)]
        public long? ExpandedDepartmentCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXAMPLE-REQUEST-ID</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SelectedDepartments")]
        [Validation(Required=false)]
        public List<GetIdentityProviderSyncScopeResponseBodySelectedDepartments> SelectedDepartments { get; set; }
        public class GetIdentityProviderSyncScopeResponseBodySelectedDepartments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Exists")]
            [Validation(Required=false)]
            public bool? Exists { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>研发部</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("SyncScope")]
        [Validation(Required=false)]
        public GetIdentityProviderSyncScopeResponseBodySyncScope SyncScope { get; set; }
        public class GetIdentityProviderSyncScopeResponseBodySyncScope : TeaModel {
            [NameInMap("DepartmentIds")]
            [Validation(Required=false)]
            public List<string> DepartmentIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SelectedDepartments</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

    }

}
