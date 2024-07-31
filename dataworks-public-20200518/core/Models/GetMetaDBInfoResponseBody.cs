// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaDBInfoResponseBody : TeaModel {
        /// <summary>
        /// The basic metadata information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaDBInfoResponseBodyData Data { get; set; }
        public class GetMetaDBInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The compute engine instance ID. Specify the ID in the `Engine type.Engine name` format.
            /// </summary>
            [NameInMap("AppGuid")]
            [Validation(Required=false)]
            public string AppGuid { get; set; }

            /// <summary>
            /// The EMR cluster ID.
            /// </summary>
            [NameInMap("ClusterBizId")]
            [Validation(Required=false)]
            public string ClusterBizId { get; set; }

            /// <summary>
            /// The comment.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The time when the compute engine instance was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The endpoint of the service.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The type of the environment. Valid values: 0 and 1. The value 0 indicates the development environment. The value 1 indicates the production environment.
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public int? EnvType { get; set; }

            /// <summary>
            /// The storage path of the metadatabase of the EMR cluster.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The time when the compute engine instance was modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the workspace owner.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The name of the workspace owner.
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The name of the workspace.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// The display name of the workspace.
            /// </summary>
            [NameInMap("ProjectNameCn")]
            [Validation(Required=false)]
            public string ProjectNameCn { get; set; }

            /// <summary>
            /// The tenant ID.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// The type of the metadatabase.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
