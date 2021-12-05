// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsRequest : TeaModel {
        /// <summary>
        /// Vpconn是否被确认
        /// </summary>
        [NameInMap("IsConfirmed")]
        [Validation(Required=false)]
        public bool? IsConfirmed { get; set; }

        /// <summary>
        /// 单次查询最大量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 单次查询最大量
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Vpconn的主Pconn
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Vpconn的OwnerUid
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionAliUids")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionAliUids { get; set; }

        /// <summary>
        /// Vpconn的商业状态
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionBusinessStatus")]
        [Validation(Required=false)]
        public string VirtualPhysicalConnectionBusinessStatus { get; set; }

        /// <summary>
        /// 根据Vpconn的ID列表过滤
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionIds")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionIds { get; set; }

        /// <summary>
        /// Vpconn的状态
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionStatuses")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionStatuses { get; set; }

        /// <summary>
        /// Vpconn的vlanId
        /// </summary>
        [NameInMap("VlanIds")]
        [Validation(Required=false)]
        public List<string> VlanIds { get; set; }

    }

}
