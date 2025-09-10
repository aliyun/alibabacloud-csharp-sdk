// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutConsumeProcessorRequest : TeaModel {
        /// <summary>
        /// <para>Consumption processor configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ConsumeProcessorConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>filter-get-request</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

    }

}
