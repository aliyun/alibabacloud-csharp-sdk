// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListUserDrawRecordByPkRequest : TeaModel {
        [NameInMap("aliyunPk")]
        [Validation(Required=false)]
        public string AliyunPk { get; set; }

        [NameInMap("drawGroup")]
        [Validation(Required=false)]
        public string DrawGroup { get; set; }

        [NameInMap("drawPoolName")]
        [Validation(Required=false)]
        public string DrawPoolName { get; set; }

    }

}
