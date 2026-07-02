// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeNetworkRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ARN of the network rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:kms:cn-hangzhou:119285303511****:network/networkrule_test</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create by kst-hzz62ee817bvyyr5****</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3bf02f7a-015b-4f93-be0f-cc043fda2d33</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The private IP addresses or private CIDR blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;192.10.XX.XX&quot;,&quot;192.168.XX.XX/24&quot;]</para>
        /// </summary>
        [NameInMap("SourcePrivateIp")]
        [Validation(Required=false)]
        public string SourcePrivateIp { get; set; }

        /// <summary>
        /// <para>The network type. The only valid value is Private, which means only private IP addresses are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
