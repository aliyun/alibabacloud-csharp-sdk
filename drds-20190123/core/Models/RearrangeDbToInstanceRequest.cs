// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class RearrangeDbToInstanceRequest : TeaModel {
        [NameInMap("ChooseRds")]
        [Validation(Required=false)]
        public string ChooseRds { get; set; }

        [NameInMap("ChooseSubDb")]
        [Validation(Required=false)]
        public string ChooseSubDb { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<string> InstanceList { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
