// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class UpdateCustomerRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("Contacter")]
        [Validation(Required=false)]
        public string Contacter { get; set; }

        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public long? CustomerId { get; set; }

        [NameInMap("Dingding")]
        [Validation(Required=false)]
        public string Dingding { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ManagerName")]
        [Validation(Required=false)]
        public string ManagerName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OuterId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        [NameInMap("OuterIdType")]
        [Validation(Required=false)]
        public int? OuterIdType { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("Position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        [NameInMap("ProdLineId")]
        [Validation(Required=false)]
        public long? ProdLineId { get; set; }

        [NameInMap("TypeCode")]
        [Validation(Required=false)]
        public string TypeCode { get; set; }

    }

}
