// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RebootCloudPhoneNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to force a restart. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Forces a restart without waiting for the instances to gracefully exit.</description></item>
        /// <item><description>false: Performs a graceful restart.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud phone matrices. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpn-05e4d1cec2urdh1j****</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

    }

}
