// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeBgpPackByIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code of the request.</para>
        /// <para>For more information about status codes, see <a href="https://help.aliyun.com/document_detail/118841.html">Common parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The configurations of the instance that is associated with the asset.</para>
        /// </summary>
        [NameInMap("DdosbgpInfo")]
        [Validation(Required=false)]
        public DescribeBgpPackByIpResponseBodyDdosbgpInfo DdosbgpInfo { get; set; }
        public class DescribeBgpPackByIpResponseBodyDdosbgpInfo : TeaModel {
            /// <summary>
            /// <para>The basic protection threshold of the instance. Unit: Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("BaseThreshold")]
            [Validation(Required=false)]
            public int? BaseThreshold { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-n6w1r7nz****</para>
            /// </summary>
            [NameInMap("DdosbgpInstanceId")]
            [Validation(Required=false)]
            public string DdosbgpInstanceId { get; set; }

            /// <summary>
            /// <para>The burstable protection threshold of the instance. Unit: Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>301</para>
            /// </summary>
            [NameInMap("ElasticThreshold")]
            [Validation(Required=false)]
            public int? ElasticThreshold { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640448000000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>118.31.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E46A08E4-A1CD-5BE9-B580-C4D6E9BC5484</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
