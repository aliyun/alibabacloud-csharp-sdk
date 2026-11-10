// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ValidateModuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The check message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The check ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF72A6FB-B07</para>
        /// </summary>
        [NameInMap("moduleValidationId")]
        [Validation(Required=false)]
        public string ModuleValidationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF72A6FB-B071-5F2E-A036-9D62545B962C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The check result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Initializing: The check is being initialized.</description></item>
        /// <item><description>Validating: The check is in progress.</description></item>
        /// <item><description>Validated: The check succeeded.</description></item>
        /// <item><description>Errored: The check failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Validating</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
