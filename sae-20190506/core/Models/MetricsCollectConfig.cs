// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class MetricsCollectConfig : TeaModel {
        [NameInMap("EnablePushToUserSLS")]
        [Validation(Required=false)]
        public bool? EnablePushToUserSLS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-sls-logstorename</para>
        /// </summary>
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-sls-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
