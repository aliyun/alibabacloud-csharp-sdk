// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class SplitTrafficControlTargetRequest : TeaModel {
        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Pre</c>: pre-production environment.</para>
        /// </description></item>
        /// <item><description><para><c>Prod</c>: production environment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID. For information about how to obtain the instance ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// </summary>
        [NameInMap("SetPoints")]
        [Validation(Required=false)]
        public List<long?> SetPoints { get; set; }

        /// <summary>
        /// <para>The target values that correspond to the time intervals defined by the <c>TimePoints</c> parameter.</para>
        /// </summary>
        [NameInMap("SetValues")]
        [Validation(Required=false)]
        public List<long?> SetValues { get; set; }

        /// <summary>
        /// <para>The time points that define the traffic-splitting intervals.</para>
        /// </summary>
        [NameInMap("TimePoints")]
        [Validation(Required=false)]
        public List<long?> TimePoints { get; set; }

    }

}
