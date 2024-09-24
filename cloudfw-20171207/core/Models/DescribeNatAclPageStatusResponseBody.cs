// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatAclPageStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Extra error information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy_not_exist</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>Indicates whether pagination for access control policies for NAT firewalls is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("NatAclPageEnable")]
        [Validation(Required=false)]
        public bool? NatAclPageEnable { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B97F9AD7-A2DB-5F8F-9206-DF89DE0AC9E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
