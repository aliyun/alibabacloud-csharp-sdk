// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupAttributeRequest : TeaModel {
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestNodePool NodePool { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestNodePool : TeaModel {
            [NameInMap("NodeCapacity")]
            [Validation(Required=false)]
            public int? NodeCapacity { get; set; }

            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

        }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestSecurityPolicy SecurityPolicy { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestSecurityPolicy : TeaModel {
            [NameInMap("ResetAfterUnbind")]
            [Validation(Required=false)]
            public bool? ResetAfterUnbind { get; set; }

            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestStoragePolicy StoragePolicy { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestStoragePolicy : TeaModel {
            [NameInMap("StorageTypeList")]
            [Validation(Required=false)]
            public List<string> StorageTypeList { get; set; }

        }

    }

}
