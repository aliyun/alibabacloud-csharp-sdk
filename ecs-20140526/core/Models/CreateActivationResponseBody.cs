// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateActivationResponseBody : TeaModel {
        /// <summary>
        /// <para>The value of the activation code. The value is returned only once when you call this operation and cannot be queried afterwards. Make sure that you properly save the returned value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a-hz0ch3SwhOlE1234+Xo32lAZC****</para>
        /// </summary>
        [NameInMap("ActivationCode")]
        [Validation(Required=false)]
        public string ActivationCode { get; set; }

        /// <summary>
        /// <para>The activation code ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ECEEE12-56F1-4FBC-9AB1-890F1234****</para>
        /// </summary>
        [NameInMap("ActivationId")]
        [Validation(Required=false)]
        public string ActivationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ECEEE12-56F1-4FBC-9AB1-890F1234****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
