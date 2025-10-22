// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class OperateCallCenterForPartnerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>esp.beian_assist</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MakeCall</para>
        /// </summary>
        [NameInMap("CallAction")]
        [Validation(Required=false)]
        public string CallAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12323213</para>
        /// </summary>
        [NameInMap("EmployeeCode")]
        [Validation(Required=false)]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Request")]
        [Validation(Required=false)]
        public string Request { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t4uor8evmq9nk</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
