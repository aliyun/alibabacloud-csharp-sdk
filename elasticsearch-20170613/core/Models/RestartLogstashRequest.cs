// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RestartLogstashRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20%</para>
        /// </summary>
        [NameInMap("batchCount")]
        [Validation(Required=false)]
        public double? BatchCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("blueGreenDep")]
        [Validation(Required=false)]
        public bool? BlueGreenDep { get; set; }

        [NameInMap("nodeTypes")]
        [Validation(Required=false)]
        public List<string> NodeTypes { get; set; }

        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("restartType")]
        [Validation(Required=false)]
        public string RestartType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
