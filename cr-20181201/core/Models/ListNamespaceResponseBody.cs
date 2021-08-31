// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListNamespaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<ListNamespaceResponseBodyNamespaces> Namespaces { get; set; }
        public class ListNamespaceResponseBodyNamespaces : TeaModel {
            [NameInMap("DefaultRepoType")]
            [Validation(Required=false)]
            public string DefaultRepoType { get; set; }

            [NameInMap("NamespaceStatus")]
            [Validation(Required=false)]
            public string NamespaceStatus { get; set; }

            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("AutoCreateRepo")]
            [Validation(Required=false)]
            public bool? AutoCreateRepo { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

        }

    }

}
