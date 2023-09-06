// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetReportTemplateByNameResponseBody : TeaModel {
        [NameInMap("defaultReceivedConvs")]
        [Validation(Required=false)]
        public List<GetReportTemplateByNameResponseBodyDefaultReceivedConvs> DefaultReceivedConvs { get; set; }
        public class GetReportTemplateByNameResponseBodyDefaultReceivedConvs : TeaModel {
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("defaultReceivers")]
        [Validation(Required=false)]
        public List<GetReportTemplateByNameResponseBodyDefaultReceivers> DefaultReceivers { get; set; }
        public class GetReportTemplateByNameResponseBodyDefaultReceivers : TeaModel {
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("Userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<GetReportTemplateByNameResponseBodyFields> Fields { get; set; }
        public class GetReportTemplateByNameResponseBodyFields : TeaModel {
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("Sort")]
            [Validation(Required=false)]
            public long? Sort { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

        }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
