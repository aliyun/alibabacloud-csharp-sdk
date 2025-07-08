// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryExportSendRecordListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QueryExportSendRecordListNewResponseBodyList List { get; set; }
        public class QueryExportSendRecordListNewResponseBodyList : TeaModel {
            [NameInMap("FcFileUpInsResponse")]
            [Validation(Required=false)]
            public List<QueryExportSendRecordListNewResponseBodyListFcFileUpInsResponse> FcFileUpInsResponse { get; set; }
            public class QueryExportSendRecordListNewResponseBodyListFcFileUpInsResponse : TeaModel {
                [NameInMap("FileFeature")]
                [Validation(Required=false)]
                public string FileFeature { get; set; }

                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("HandlerStatus")]
                [Validation(Required=false)]
                public int? HandlerStatus { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
