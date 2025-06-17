// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCnameResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the CNAME detection results.</para>
        /// </summary>
        [NameInMap("CnameDatas")]
        [Validation(Required=false)]
        public DescribeDomainCnameResponseBodyCnameDatas CnameDatas { get; set; }
        public class DescribeDomainCnameResponseBodyCnameDatas : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDomainCnameResponseBodyCnameDatasData> Data { get; set; }
            public class DescribeDomainCnameResponseBodyCnameDatasData : TeaModel {
                /// <summary>
                /// <para>The CNAME assigned to the domain name by Alibaba Cloud CDN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a.com.w.alikunlun.net</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a.com</para>
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
                /// <para>The CNAME detection result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The DNS can detect the CNAME assigned to the domain name.</description></item>
                /// <item><description>Value other than 0: The DNS cannot detect the CNAME assigned to the domain name.</description></item>
                /// </list>
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
