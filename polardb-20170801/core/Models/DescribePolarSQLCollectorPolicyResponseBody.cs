// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarSQLCollectorPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1s826a1up******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3655211B-4D74-4E13-91E6-FF2AFE******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the SQL Explorer feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enable</b>: The feature is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: The feature is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("SQLCollectorStatus")]
        [Validation(Required=false)]
        public string SQLCollectorStatus { get; set; }

    }

}
