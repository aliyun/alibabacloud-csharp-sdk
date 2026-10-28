// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CloneLaboratoryRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clone the experiment groups.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CloneExperimentGroup")]
        [Validation(Required=false)]
        public bool? CloneExperimentGroup { get; set; }

        /// <summary>
        /// <para>The runtime environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: daily environment.</description></item>
        /// <item><description>Pre: pre-release environment.</description></item>
        /// <item><description>Prod: production environment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance. You can call the ListInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-abcdefg1234</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
