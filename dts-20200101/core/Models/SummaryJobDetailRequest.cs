// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SummaryJobDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration or data synchronization instance.</para>
        /// <remarks>
        /// <para> You must specify at least one of the DtsJobId and DtsInstanceId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsl3m1213ye7l****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or data synchronization task.</para>
        /// <remarks>
        /// <para> You must specify at least one of the DtsJobId and DtsInstanceId parameters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3m1213ye7l****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The phase of the data migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>02</b>: The task is in the schema migration phase.</description></item>
        /// <item><description><b>03</b>: The task is in the incremental migration phase.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("JobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// <para>The region ID of the DTS instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of schema definition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>before</b>: schema migration or initial schema synchronization</description></item>
        /// <item><description><b>after</b>: DDL operations performed during incremental data migration or synchronization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>before</para>
        /// </summary>
        [NameInMap("StructType")]
        [Validation(Required=false)]
        public string StructType { get; set; }

        /// <summary>
        /// <para>The synchronization direction of the data synchronization task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b>: Data is synchronized from the source database to the destination database.</description></item>
        /// <item><description><b>Reverse</b>: Data is synchronized from the destination database to the source database.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// <item><description>You can set this parameter to <b>Reverse</b> to delete the reverse synchronization task only if the topology is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
