// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DataInstancesValue : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-wb7r6dlwetvt5j****.cn-hangzhou.nlb.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DnsName")]
        [Validation(Required=false)]
        public string DnsName { get; set; }

        /// <summary>
        /// <para>The listeners.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public Dictionary<string, DataInstancesValueListenersValue> Listeners { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is created by SAE.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is created by SAE.</description></item>
        /// <item><description><b>false</b>: The existing instance is reused.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CreatedBySae")]
        [Validation(Required=false)]
        public bool? CreatedBySae { get; set; }

    }

}
