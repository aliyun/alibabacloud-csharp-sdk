// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class AddEnvironmentProductVersionsRequest : TeaModel {
        [NameInMap("productVersionInfoList")]
        [Validation(Required=false)]
        public List<AddEnvironmentProductVersionsRequestProductVersionInfoList> ProductVersionInfoList { get; set; }
        public class AddEnvironmentProductVersionsRequestProductVersionInfoList : TeaModel {
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("productVersionUID")]
            [Validation(Required=false)]
            public string ProductVersionUID { get; set; }

            [NameInMap("specUID")]
            [Validation(Required=false)]
            public string SpecUID { get; set; }

        }

        [NameInMap("productVersionUIDList")]
        [Validation(Required=false)]
        public List<string> ProductVersionUIDList { get; set; }

    }

}
