// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class TestEventSourceConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are configured if you specify MySQL as the event source.</para>
        /// </summary>
        [NameInMap("SourceMySQLParameters")]
        [Validation(Required=false)]
        public string SourceMySQLParametersShrink { get; set; }

    }

}
