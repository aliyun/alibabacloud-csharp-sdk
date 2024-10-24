// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAccessModeResponseBody : TeaModel {
        /// <summary>
        /// <para>An array consisting of the modes in which the website service is added.</para>
        /// </summary>
        [NameInMap("DomainModes")]
        [Validation(Required=false)]
        public List<DescribeWebAccessModeResponseBodyDomainModes> DomainModes { get; set; }
        public class DescribeWebAccessModeResponseBodyDomainModes : TeaModel {
            /// <summary>
            /// <para>The mode in which the website service is added. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: A record</description></item>
            /// <item><description><b>1</b>: anti-DDoS mode</description></item>
            /// <item><description><b>2</b>: origin redundancy mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public int? AccessMode { get; set; }

            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bcf28g5-d57c-11e7-9bs0-d89d6717dxbc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
