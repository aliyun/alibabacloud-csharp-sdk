// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebAccessModeRequest : TeaModel {
        /// <summary>
        /// <para>The mode in which a website service is added to Anti-DDoS Pro or Anti-DDoS Premium. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: A record mode</description></item>
        /// <item><description><b>1</b>: anti-DDoS mode</description></item>
        /// <item><description><b>2</b>: origin redundancy mode</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public int? AccessMode { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}
