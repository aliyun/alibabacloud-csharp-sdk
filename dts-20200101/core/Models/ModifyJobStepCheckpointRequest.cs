// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyJobStepCheckpointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the migration, synchronization, or tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l5512es7w15****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The task step ID, which corresponds to the <b>synchronization</b> step ID returned by the ListJobStep API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn3z4ukia9wi9xu_0004_0000</para>
        /// </summary>
        [NameInMap("JobStepId")]
        [Validation(Required=false)]
        public string JobStepId { get; set; }

        /// <summary>
        /// <para>The new offset as a UNIX timestamp in seconds. The specified value must fall within the offset range of the incremental data collection step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760406***</para>
        /// </summary>
        [NameInMap("NewCheckPoint")]
        [Validation(Required=false)]
        public long? NewCheckPoint { get; set; }

        /// <summary>
        /// <para>The region where the DTS instance resides.</para>
        /// <remarks>
        /// <para>For regions that support dedicated clusters, see <a href="https://help.aliyun.com/document_detail/417481.html">DTS dedicated cluster</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2ilvoxlrd***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
