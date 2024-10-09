// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class LoginInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The URL that you use to log on to the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ecs-workbench.aliyun.com/view/instance/single/gbktfz">https://ecs-workbench.aliyun.com/view/instance/single/gbktfz</a>****</para>
        /// </summary>
        [NameInMap("RedirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2DE174B-7196-5778-A00D-6EA2601B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
