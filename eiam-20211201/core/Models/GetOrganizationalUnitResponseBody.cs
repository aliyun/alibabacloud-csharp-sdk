// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetOrganizationalUnitResponseBody : TeaModel {
        /// <summary>
        /// The data object of the organizational unit.
        /// </summary>
        [NameInMap("OrganizationalUnit")]
        [Validation(Required=false)]
        public GetOrganizationalUnitResponseBodyOrganizationalUnit OrganizationalUnit { get; set; }
        public class GetOrganizationalUnitResponseBodyOrganizationalUnit : TeaModel {
            /// <summary>
            /// The time when the organizational unit was created. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the organizational unit.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Indicates whether the node is a leaf node.
            /// </summary>
            [NameInMap("Leaf")]
            [Validation(Required=false)]
            public bool? Leaf { get; set; }

            /// <summary>
            /// The external ID of the organizational unit. The external ID can be used by external data to map the data of the organizational unit in IDaaS EIAM. By default, the external ID is the organizational unit ID.
            /// 
            /// For organizational units with the same source type and source ID, each organizational unit has a unique external ID.
            /// </summary>
            [NameInMap("OrganizationalUnitExternalId")]
            [Validation(Required=false)]
            public string OrganizationalUnitExternalId { get; set; }

            /// <summary>
            /// The ID of the organizational unit.
            /// </summary>
            [NameInMap("OrganizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// 组织名称。
            /// </summary>
            [NameInMap("OrganizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            /// <summary>
            /// The source ID of the organizational unit.
            /// 
            /// If the organizational unit was created in IDaaS, its source ID is the ID of the IDaaS instance. If the organizational unit was imported, its source ID is the enterprise ID in the source. For example, if the organizational unit was imported from DingTalk, its source ID is the corpId value of the enterprise in DingTalk.
            /// </summary>
            [NameInMap("OrganizationalUnitSourceId")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceId { get; set; }

            /// <summary>
            /// The source type of the organizational unit. Valid values:
            /// 
            /// *   build_in: The organizational unit was created in IDaaS.
            /// *   ding_talk: The organizational unit was imported from DingTalk.
            /// *   ad: The organizational unit was imported from Microsoft Active Directory (AD).
            /// *   ldap: The organizational unit was imported from a Lightweight Directory Access Protocol (LDAP) service.
            /// </summary>
            [NameInMap("OrganizationalUnitSourceType")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceType { get; set; }

            /// <summary>
            /// The ID of the parent organizational unit.
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// The time when the organizational unit was last updated. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
