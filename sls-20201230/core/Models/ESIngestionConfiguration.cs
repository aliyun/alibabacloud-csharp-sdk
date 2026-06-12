// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ESIngestionConfiguration : TeaModel {
        /// <summary>
        /// <para>The Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public ESIngestionConfigurationSource Source { get; set; }

    }

}
