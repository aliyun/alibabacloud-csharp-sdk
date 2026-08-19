// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserVipsByDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name for ApsaraVideo VOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6730AC93-7B12-4B*****7F-49EE1FE8BC49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Vips")]
        [Validation(Required=false)]
        public DescribeVodUserVipsByDomainResponseBodyVips Vips { get; set; }
        public class DescribeVodUserVipsByDomainResponseBodyVips : TeaModel {
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public List<string> Vip { get; set; }

        }

    }

}
