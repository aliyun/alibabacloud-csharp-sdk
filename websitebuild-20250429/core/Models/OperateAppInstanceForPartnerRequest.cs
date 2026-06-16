// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class OperateAppInstanceForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>The extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;deliveryNodeName\&quot;:\&quot;交付质检\&quot;,\&quot;deliveryNodeStatus\&quot;:\&quot;Finish\&quot;,\&quot;deliveryOperatorRole\&quot;:\&quot;Provider\&quot;}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The operation event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SERVICE_DELIVERY_PROCESS</para>
        /// </summary>
        [NameInMap("OperateEvent")]
        [Validation(Required=false)]
        public string OperateEvent { get; set; }

    }

}
