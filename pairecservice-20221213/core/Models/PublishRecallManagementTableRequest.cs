// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class PublishRecallManagementTableRequest : TeaModel {
        /// <summary>
        /// <para><b>The instance ID.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para><b>The synchronization mode.</b> Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Merge</c>: Adds new data and updates existing data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Merge</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The table partitions to publish.</para>
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public Dictionary<string, string> Partition { get; set; }

        /// <summary>
        /// <para>The table partitions to publish.</para>
        /// </summary>
        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, string> Partitions { get; set; }

        /// <summary>
        /// <para><b>Specifies whether to skip the threshold check during table synchronization.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SkipThresholdCheck")]
        [Validation(Required=false)]
        public bool? SkipThresholdCheck { get; set; }

    }

}
