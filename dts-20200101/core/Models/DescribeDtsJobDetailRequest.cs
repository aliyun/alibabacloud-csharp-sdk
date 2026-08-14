// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobDetailRequest : TeaModel {
        [NameInMap("DbObjectOutputType")]
        [Validation(Required=false)]
        public string DbObjectOutputType { get; set; }

        /// <summary>
        /// <para>The instance ID of the data migration, data synchronization, or subscribe instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsta7w132u12h****</para>
        /// </summary>
        [NameInMap("DtsInstanceID")]
        [Validation(Required=false)]
        public string DtsInstanceID { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta7w132u12h****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the task resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return information about all synchronization subtasks. Default value: <b>false</b>, which returns only the synchronization subtask that is in progress or the most recently executed synchronization subtask.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncSubJobHistory")]
        [Validation(Required=false)]
        public bool? SyncSubJobHistory { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b>: forward.</description></item>
        /// <item><description><b>Reverse</b>: reverse.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The value <b>Reverse</b> takes effect only when the synchronization topology of the data synchronization instance is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>Specifies whether the task is a zero-ETL task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The task is a zero-ETL task.</description></item>
        /// <item><description><b>false</b>: The task is not a zero-ETL task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
