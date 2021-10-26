// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class InstanceLifecycleConfig : TeaModel {
        [NameInMap("preFreeze")]
        [Validation(Required=false)]
        public LifecycleHook PreFreeze { get; set; }

        [NameInMap("preStop")]
        [Validation(Required=false)]
        public LifecycleHook PreStop { get; set; }

    }

}
