// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadMessageListRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        [NameInMap("CallerProtocol")]
        [Validation(Required=false)]
        public string CallerProtocol { get; set; }

        [NameInMap("ClassId")]
        [Validation(Required=false)]
        public long? ClassId { get; set; }

        [NameInMap("ClientSource")]
        [Validation(Required=false)]
        public string ClientSource { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public string Cookies { get; set; }

        [NameInMap("Loc")]
        [Validation(Required=false)]
        public string Loc { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SrcUrl")]
        [Validation(Required=false)]
        public string SrcUrl { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UidType")]
        [Validation(Required=false)]
        public string UidType { get; set; }

    }

}
