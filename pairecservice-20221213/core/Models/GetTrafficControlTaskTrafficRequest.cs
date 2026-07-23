// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTaskTrafficRequest : TeaModel {
        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Daily</c>: The daily environment.</para>
        /// </description></item>
        /// <item><description><para><c>Pre</c>: The staging environment.</para>
        /// </description></item>
        /// <item><description><para><c>Prod</c>: The production environment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pre</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID. For more information, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
