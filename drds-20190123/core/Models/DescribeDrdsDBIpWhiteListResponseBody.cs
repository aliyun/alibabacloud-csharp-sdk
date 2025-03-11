// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBIpWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address whitelist.</para>
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public DescribeDrdsDBIpWhiteListResponseBodyIpWhiteList IpWhiteList { get; set; }
        public class DescribeDrdsDBIpWhiteListResponseBodyIpWhiteList : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public List<string> Ip { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>017453B9-0001-4745-87BF-DD612D850ED0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
