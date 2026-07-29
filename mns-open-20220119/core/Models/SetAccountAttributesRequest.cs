// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SetAccountAttributesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>06273500-249</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LogEnabled")]
        [Validation(Required=false)]
        public bool? LogEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MessageTraceEnabled")]
        [Validation(Required=false)]
        public bool? MessageTraceEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
