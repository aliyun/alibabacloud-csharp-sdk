// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckDomainResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Avail")]
        [Validation(Required=false)]
        public string Avail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test**.xin</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DynamicCheck")]
        [Validation(Required=false)]
        public bool? DynamicCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Premium")]
        [Validation(Required=false)]
        public string Premium { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1286</para>
        /// </summary>
        [NameInMap("Price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>In use</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BA7A4FD4-EB9A-4A20-BB0C-9AEB15634DC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StaticPriceInfo")]
        [Validation(Required=false)]
        public CheckDomainResponseBodyStaticPriceInfo StaticPriceInfo { get; set; }
        public class CheckDomainResponseBodyStaticPriceInfo : TeaModel {
            [NameInMap("PriceInfo")]
            [Validation(Required=false)]
            public List<CheckDomainResponseBodyStaticPriceInfoPriceInfo> PriceInfo { get; set; }
            public class CheckDomainResponseBodyStaticPriceInfoPriceInfo : TeaModel {
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("money")]
                [Validation(Required=false)]
                public double? Money { get; set; }

                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

            }

        }

    }

}
