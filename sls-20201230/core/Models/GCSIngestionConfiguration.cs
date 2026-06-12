// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GCSIngestionConfiguration : TeaModel {
        /// <summary>
        /// <para>The name of the destination logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myLogstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The data source configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public GCSIngestionConfigurationSource Source { get; set; }

    }

}
