// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAllTenantBindNumberBindingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAllTenantBindNumberBindingResponseBodyData Data { get; set; }
        public class ListAllTenantBindNumberBindingResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAllTenantBindNumberBindingResponseBodyDataList> List { get; set; }
            public class ListAllTenantBindNumberBindingResponseBodyDataList : TeaModel {
                [NameInMap("BillingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                [NameInMap("BindingId")]
                [Validation(Required=false)]
                public string BindingId { get; set; }

                [NameInMap("InstanceNameList")]
                [Validation(Required=false)]
                public List<string> InstanceNameList { get; set; }

                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("SerializedParams")]
                [Validation(Required=false)]
                public string SerializedParams { get; set; }

                [NameInMap("TrunkName")]
                [Validation(Required=false)]
                public string TrunkName { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
