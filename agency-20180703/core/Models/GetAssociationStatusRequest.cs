// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetAssociationStatusRequest : TeaModel {
        [NameInMap("AliyunPk")]
        [Validation(Required=false)]
        public long? AliyunPk { get; set; }

        [NameInMap("GetAssociationStatusList")]
        [Validation(Required=false)]
        public List<GetAssociationStatusRequestGetAssociationStatusList> GetAssociationStatusList { get; set; }
        public class GetAssociationStatusRequestGetAssociationStatusList : TeaModel {
            [NameInMap("InviteId")]
            [Validation(Required=false)]
            public long? InviteId { get; set; }

        }

    }

}
