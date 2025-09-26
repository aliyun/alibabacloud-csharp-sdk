// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateToolInput : TeaModel {
        [NameInMap("CAPConfig")]
        [Validation(Required=false)]
        public CAPConfig CAPConfig { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("toolType")]
        [Validation(Required=false)]
        public string ToolType { get; set; }

    }

}
