// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListIdpConfigsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIdpConfigsResponseBodyData Data { get; set; }
        public class ListIdpConfigsResponseBodyData : TeaModel {
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListIdpConfigsResponseBodyDataDataList> DataList { get; set; }
            public class ListIdpConfigsResponseBodyDataDataList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Mfa")]
                [Validation(Required=false)]
                public string Mfa { get; set; }

                [NameInMap("MobileLoginType")]
                [Validation(Required=false)]
                public string MobileLoginType { get; set; }

                [NameInMap("MobileMfaConfigType")]
                [Validation(Required=false)]
                public string MobileMfaConfigType { get; set; }

                [NameInMap("MultiIdpInfo")]
                [Validation(Required=false)]
                public string MultiIdpInfo { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PcLoginType")]
                [Validation(Required=false)]
                public string PcLoginType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
