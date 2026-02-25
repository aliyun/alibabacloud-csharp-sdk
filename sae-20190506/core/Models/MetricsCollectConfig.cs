// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class MetricsCollectConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to push metric data to Simple Log Service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePushToUserSLS")]
        [Validation(Required=false)]
        public bool? EnablePushToUserSLS { get; set; }

        /// <summary>
        /// <para>The name of the Logstore in Simple Log Service to which the metric data is pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-sls-logstorename</para>
        /// </summary>
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The name of the project in Simple Log Service to which the metric data is pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-sls-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
