// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponseBodyResult Result { get; set; }
        public class DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponseBodyResult : TeaModel {
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            [NameInMap("AuthorizedUserList")]
            [Validation(Required=false)]
            public List<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponseBodyResultAuthorizedUserList> AuthorizedUserList { get; set; }
            public class DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponseBodyResultAuthorizedUserList : TeaModel {
                [NameInMap("GmtAuthorized")]
                [Validation(Required=false)]
                public string GmtAuthorized { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponseBodyResultPagination : TeaModel {
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

    }

}
