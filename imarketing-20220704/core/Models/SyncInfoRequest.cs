// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class SyncInfoRequest : TeaModel {
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public string AccountNo { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ChainValue")]
        [Validation(Required=false)]
        public string ChainValue { get; set; }

        [NameInMap("ComponentIdList")]
        [Validation(Required=false)]
        public string ComponentIdList { get; set; }

        [NameInMap("CreateUser")]
        [Validation(Required=false)]
        public string CreateUser { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        [NameInMap("MainId")]
        [Validation(Required=false)]
        public long? MainId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NextChainValue")]
        [Validation(Required=false)]
        public string NextChainValue { get; set; }

        [NameInMap("OssFileUrl")]
        [Validation(Required=false)]
        public string OssFileUrl { get; set; }

        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("UpdateUser")]
        [Validation(Required=false)]
        public string UpdateUser { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("UrlType")]
        [Validation(Required=false)]
        public int? UrlType { get; set; }

    }

}
