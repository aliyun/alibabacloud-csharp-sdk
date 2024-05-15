// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListDocumentsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// schema id
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SchemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

        [NameInMap("SearchPattern")]
        [Validation(Required=false)]
        public string SearchPattern { get; set; }

        [NameInMap("Sorts")]
        [Validation(Required=false)]
        public List<ListDocumentsRequestSorts> Sorts { get; set; }
        public class ListDocumentsRequestSorts : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            [NameInMap("PropertyName")]
            [Validation(Required=false)]
            public string PropertyName { get; set; }

        }

    }

}
