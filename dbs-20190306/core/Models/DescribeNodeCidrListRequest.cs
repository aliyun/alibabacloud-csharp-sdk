// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeNodeCidrListRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The region in which DBS is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: China (Hangzhou)</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: China (Shanghai)</para>
        /// </description></item>
        /// <item><description><para><b>cn-qingdao</b>: China (Qingdao)</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing</b>: China (Beijing)</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen</b>: China (Shenzhen)</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong)</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Singapore (Singapore)</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-finance</b>: China East 1 Finance</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai-finance</b>: China East 2 Finance</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen-finance</b>: China South 1 Finance</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
