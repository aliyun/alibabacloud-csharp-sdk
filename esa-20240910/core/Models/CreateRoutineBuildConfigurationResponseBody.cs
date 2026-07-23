// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineBuildConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ER build configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3472165674357056</para>
        /// </summary>
        [NameInMap("RoutineBuildConfigurationId")]
        [Validation(Required=false)]
        public long? RoutineBuildConfigurationId { get; set; }

    }

}
