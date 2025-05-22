// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class OperateProduceForPartnerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>P20210930105636000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esp.beian_assist</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;beianServiceNumber\&quot;:\&quot;9969c666-0935-4c5b-8042-926ff546e39f\&quot;}</para>
        /// </summary>
        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CERT_MATERIAL_SUBMITTED</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

    }

}
