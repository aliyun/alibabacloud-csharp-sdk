// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAgentlessTaskCountRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-m5edddcwq7d57d******</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>Specifies the type of the object being inspected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b>: User Snapshot.</description></item>
        /// <item><description><b>4</b>: User Image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

    }

}
