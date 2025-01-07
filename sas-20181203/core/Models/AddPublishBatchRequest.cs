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
        /// <para>test</para>
        /// </summary>
        [NameInMap("BatchName")]
        [Validation(Required=false)]
        public string BatchName { get; set; }

        /// <summary>
        /// <para>The interval between two release batches.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The dimension based on which the asset is selected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: selects the asset by instance.</description></item>
        /// <item><description><b>1</b>: selects the asset by machine group.</description></item>
        /// <item><description><b>2</b>: selects the asset by the ID of the instance that is deployed in the virtual private cloud (VPC).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperationBase")]
        [Validation(Required=false)]
        public int? OperationBase { get; set; }

        /// <summary>
        /// <para>The version to which you want to upgrade the agent.</para>
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
