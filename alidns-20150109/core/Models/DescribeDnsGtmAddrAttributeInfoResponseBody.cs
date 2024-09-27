// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddrAttributeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The address in the address pool.</para>
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public DescribeDnsGtmAddrAttributeInfoResponseBodyAddr Addr { get; set; }
        public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddr : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddr> Addr { get; set; }
            public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddr : TeaModel {
                /// <summary>
                /// <para>The address in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public string Addr { get; set; }

                /// <summary>
                /// <para>The information about the source region of the address.</para>
                /// </summary>
                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddrAttributeInfo AttributeInfo { get; set; }
                public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddrAttributeInfo : TeaModel {
                    /// <summary>
                    /// <para>The parent line code of the source region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>telecom</para>
                    /// </summary>
                    [NameInMap("FatherCode")]
                    [Validation(Required=false)]
                    public string FatherCode { get; set; }

                    /// <summary>
                    /// <para>The code of the source region group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEFAULT</para>
                    /// </summary>
                    [NameInMap("GroupCode")]
                    [Validation(Required=false)]
                    public string GroupCode { get; set; }

                    /// <summary>
                    /// <para>The name of the source region group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Global</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The line code of the source region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("LineCode")]
                    [Validation(Required=false)]
                    public string LineCode { get; set; }

                    /// <summary>
                    /// <para>The line name of the source region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Global</para>
                    /// </summary>
                    [NameInMap("LineName")]
                    [Validation(Required=false)]
                    public string LineName { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
