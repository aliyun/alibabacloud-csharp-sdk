// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCnameResponseBody : TeaModel {
        [NameInMap("CnameDatas")]
        [Validation(Required=false)]
        public DescribeDomainCnameResponseBodyCnameDatas CnameDatas { get; set; }
        public class DescribeDomainCnameResponseBodyCnameDatas : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDomainCnameResponseBodyCnameDatasData> Data { get; set; }
            public class DescribeDomainCnameResponseBodyCnameDatasData : TeaModel {
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("Passed")]
                [Validation(Required=false)]
                public string Passed { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06D29681-B7CD-4034-A8CC-28AFFA213539</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
