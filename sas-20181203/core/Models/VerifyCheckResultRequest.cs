// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckResultRequest : TeaModel {
        /// <summary>
        /// <para>The list of check item IDs.</para>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

        /// <summary>
        /// <para>The list of instance IDs of the assets associated with the check items.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The task source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>YAO_CHI</b>: ApsaraDB console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>YAO_CHI</para>
        /// </summary>
        [NameInMap("TaskSource")]
        [Validation(Required=false)]
        public string TaskSource { get; set; }

    }

}
