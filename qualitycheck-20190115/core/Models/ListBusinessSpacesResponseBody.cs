// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListBusinessSpacesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBusinessSpacesResponseBodyData> Data { get; set; }
        public class ListBusinessSpacesResponseBodyData : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("BusinessSpaceCode")]
            [Validation(Required=false)]
            public string BusinessSpaceCode { get; set; }

            [NameInMap("BusinessSpaceName")]
            [Validation(Required=false)]
            public string BusinessSpaceName { get; set; }

            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public int? CurrentStatus { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("LoginUserType")]
            [Validation(Required=false)]
            public int? LoginUserType { get; set; }

            [NameInMap("OrderInstanceId")]
            [Validation(Required=false)]
            public string OrderInstanceId { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("SubAliUid")]
            [Validation(Required=false)]
            public long? SubAliUid { get; set; }

            [NameInMap("XspaceCommodityCode")]
            [Validation(Required=false)]
            public string XspaceCommodityCode { get; set; }

            [NameInMap("XspaceProductCode")]
            [Validation(Required=false)]
            public string XspaceProductCode { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
