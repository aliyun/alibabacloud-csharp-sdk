// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class CreateStoreRequest : TeaModel {
        [NameInMap("AutoUnbindDays")]
        [Validation(Required=false)]
        public int? AutoUnbindDays { get; set; }

        [NameInMap("AutoUnbindOfflineEsl")]
        [Validation(Required=false)]
        public bool? AutoUnbindOfflineEsl { get; set; }

        [NameInMap("BarCodeEncode")]
        [Validation(Required=false)]
        public int? BarCodeEncode { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public string ExtraParams { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("UserStoreCode")]
        [Validation(Required=false)]
        public string UserStoreCode { get; set; }

    }

}
