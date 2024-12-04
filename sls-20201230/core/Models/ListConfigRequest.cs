// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the Logtail configuration, which is used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logtail-config-sample</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-logstore</para>
        /// </summary>
        [NameInMap("logstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The line from which the query starts. Default value: 0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
