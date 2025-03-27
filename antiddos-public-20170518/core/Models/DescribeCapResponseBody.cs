// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeCapResponseBody : TeaModel {
        /// <summary>
        /// <para>The download link to the traffic data that is captured when a DDoS attack event occurs.</para>
        /// </summary>
        [NameInMap("CapUrl")]
        [Validation(Required=false)]
        public DescribeCapResponseBodyCapUrl CapUrl { get; set; }
        public class DescribeCapResponseBodyCapUrl : TeaModel {
            /// <summary>
            /// <para>The download link to the traffic data.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://beaver-pack****.oss-cn-hangzhou.aliyuncs.com/ddos-2021112511-121.89.XX.XX.cap?Expires=1637824408&OSSAccessKeyId=LTAIXu2lJhw3****&Signature=KKSzOMSUajtwcqfqxkU1nK69d4">http://beaver-pack****.oss-cn-hangzhou.aliyuncs.com/ddos-2021112511-121.89.XX.XX.cap?Expires=1637824408&amp;OSSAccessKeyId=LTAIXu2lJhw3****&amp;Signature=KKSzOMSUajtwcqfqxkU1nK69d4</a>****</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C728D7E9-9A39-52E0-966B-5C33118BDBB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
