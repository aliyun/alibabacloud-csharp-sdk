// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateActivationResponseBody : TeaModel {
        /// <summary>
        /// <para>The value of the activation code. The value is returned only once after the CreateActivation operation is called and cannot be queried afterward. Properly save the return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a-hz0ch3SwhOlE1234+Xo32lAZC****</para>
        /// </summary>
        [NameInMap("ActivationCode")]
        [Validation(Required=false)]
        public string ActivationCode { get; set; }

        /// <summary>
        /// <para>The ID of the activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ECEEE12-56F1-4FBC-9AB1-890F1234****</para>
        /// </summary>
        [NameInMap("ActivationId")]
        [Validation(Required=false)]
        public string ActivationId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ECEEE12-56F1-4FBC-9AB1-890F1234****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
