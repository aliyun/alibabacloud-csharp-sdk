// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainsBySourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about each origin server and the corresponding domain names.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DomainInfo")]
        [Validation(Required=false)]
        public List<DescribeDcdnDomainsBySourceResponseBodyDomainInfo> DomainInfo { get; set; }
        public class DescribeDcdnDomainsBySourceResponseBodyDomainInfo : TeaModel {
            /// <summary>
            /// <para>The information about the domain names.</para>
            /// </summary>
            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainsBySourceResponseBodyDomainInfoDomainList> DomainList { get; set; }
            public class DescribeDcdnDomainsBySourceResponseBodyDomainInfoDomainList : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-21T03:05:20+08:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The CNAME record assigned to the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.org.alikunlun.com</para>
                /// </summary>
                [NameInMap("DomainCname")]
                [Validation(Required=false)]
                public string DomainCname { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.org</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The workload type of the accelerated domain name. Valid value:</para>
                /// <list type="bullet">
                /// <item><description><b>ipa</b>: layer 4 acceleration</description></item>
                /// <item><description><b>dynamic</b>: layer 7 acceleration</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dynamic</para>
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// <para>The status of the domain name. Valid value:</para>
                /// <list type="bullet">
                /// <item><description><b>applying</b>: The domain name is under review.</description></item>
                /// <item><description><b>configuring</b>: The domain name is being configured.</description></item>
                /// <item><description><b>online</b>: The domain name is working as expected.</description></item>
                /// <item><description><b>stopping</b>: The domain name is being stopped.</description></item>
                /// <item><description><b>offline</b>: The domain name is disabled.</description></item>
                /// <item><description><b>disabling</b>: The domain name is being removed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the domain name was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-01T03:26:55+08:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F61CDR30-E83C-4FDA-BF73-9A94CDD44229</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
