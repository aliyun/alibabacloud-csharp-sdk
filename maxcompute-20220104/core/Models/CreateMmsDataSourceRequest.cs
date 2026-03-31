// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsDataSourceRequest : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-uf6pc2vordian33gobzfr:cn-shanghai</para>
        /// </summary>
        [NameInMap("networklink")]
        [Validation(Required=false)]
        public string Networklink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BIGQUERY</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
