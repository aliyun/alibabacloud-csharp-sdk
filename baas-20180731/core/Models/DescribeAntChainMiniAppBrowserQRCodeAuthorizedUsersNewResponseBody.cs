// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersNewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersNewResponseBodyResult Result { get; set; }
        public class DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersNewResponseBodyResult : TeaModel {
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            [NameInMap("AuthorizedUserList")]
            [Validation(Required=false)]
            public List<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersNewResponseBodyResultAuthorizedUserList> AuthorizedUserList { get; set; }
            public class DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersNewResponseBodyResultAuthorizedUserList : TeaModel {
                [NameInMap("GmtAuthorized")]
                [Validation(Required=false)]
                public string GmtAuthorized { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersNewResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersNewResponseBodyResultPagination : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            [NameInMap("QRCodeType")]
            [Validation(Required=false)]
            public string QRCodeType { get; set; }

        }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
