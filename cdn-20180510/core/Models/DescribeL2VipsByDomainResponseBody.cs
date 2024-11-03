// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeL2VipsByDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of VIPs.</para>
        /// </summary>
        [NameInMap("Vips")]
        [Validation(Required=false)]
        public DescribeL2VipsByDomainResponseBodyVips Vips { get; set; }
        public class DescribeL2VipsByDomainResponseBodyVips : TeaModel {
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public List<string> Vip { get; set; }

        }

    }

}
