// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class EvaluateLocalExtendDiskResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the expansion is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Available.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Not available.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Available")]
        [Validation(Required=false)]
        public string Available { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-wz9s06u4drm******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The transfer type of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DBInstanceTransType")]
        [Validation(Required=false)]
        public string DBInstanceTransType { get; set; }

        /// <summary>
        /// <para>The maximum capacity of the local disk. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("LocalUpgradeDiskLimit")]
        [Validation(Required=false)]
        public long? LocalUpgradeDiskLimit { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4C4D26F-E5CE-5A28-8C54-46A6FB318223</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
