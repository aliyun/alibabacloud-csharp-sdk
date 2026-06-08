// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ABTestExperiment : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my_test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("online")]
        [Validation(Required=false)]
        public bool? Online { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>85373</para>
        /// </summary>
        [NameInMap("serialNumber")]
        [Validation(Required=false)]
        public int? SerialNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("traffic")]
        [Validation(Required=false)]
        public int? Traffic { get; set; }

    }

}
