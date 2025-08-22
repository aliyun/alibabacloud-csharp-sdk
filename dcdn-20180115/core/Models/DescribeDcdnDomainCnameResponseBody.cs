// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCnameResponseBody : TeaModel {
        /// <summary>
        /// <para>The CNAME information.</para>
        /// </summary>
        [NameInMap("CnameDatas")]
        [Validation(Required=false)]
        public DescribeDcdnDomainCnameResponseBodyCnameDatas CnameDatas { get; set; }
        public class DescribeDcdnDomainCnameResponseBodyCnameDatas : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainCnameResponseBodyCnameDatasData> Data { get; set; }
            public class DescribeDcdnDomainCnameResponseBodyCnameDatasData : TeaModel {
                /// <summary>
                /// <para>The CNAME assigned to the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.com</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>.example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("Passed")]
                [Validation(Required=false)]
                public string Passed { get; set; }

                /// <summary>
                /// <para>The configuration status of the CNAME record. If the operation returns 0 for the parameter, the configuration was successful. Otherwise, the configuration failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
