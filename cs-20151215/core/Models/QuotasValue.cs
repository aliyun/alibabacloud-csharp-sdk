// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class QuotasValue : Darabonba.Model {
        /// <summary>
        /// <para>The quota value. If you need to exceed the quota, submit a request on the <a href="https://quotas.console.aliyun.com/products/csk/quotas">Quota Center page</a> to increase the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public string Quota { get; set; }

        /// <summary>
        /// <para>The quota code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>q_Kubernetes_Cluster</para>
        /// </summary>
        [NameInMap("operation_code")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>Indicates whether the quota is adjustable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("adjustable")]
        [Validation(Required=false)]
        public bool? Adjustable { get; set; }

        /// <summary>
        /// <para>The unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}

