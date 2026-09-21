// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddPublishBatchRequest : TeaModel {
        /// <summary>
        /// <para>The name of the release batch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Batch1</para>
        /// </summary>
        [NameInMap("BatchName")]
        [Validation(Required=false)]
        public string BatchName { get; set; }

        /// <summary>
        /// <para>The interval between release batches.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The dimension for asset selection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: server instance</description></item>
        /// <item><description><b>1</b>: server group</description></item>
        /// <item><description><b>2</b>: VPC-connected instance ID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperationBase")]
        [Validation(Required=false)]
        public int? OperationBase { get; set; }

        /// <summary>
        /// <para>The target version to which you want to upgrade.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.9</para>
        /// </summary>
        [NameInMap("UpgradeVersion")]
        [Validation(Required=false)]
        public string UpgradeVersion { get; set; }

    }

}
