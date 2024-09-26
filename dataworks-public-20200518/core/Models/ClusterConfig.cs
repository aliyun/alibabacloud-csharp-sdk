// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ClusterConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;spark.driver.memory&quot;:&quot;1g&quot;}</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableOverwrite")]
        [Validation(Required=false)]
        public bool? EnableOverwrite { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ide</para>
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

    }

}
