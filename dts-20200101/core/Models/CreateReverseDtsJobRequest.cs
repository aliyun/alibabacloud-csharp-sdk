// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateReverseDtsJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the synchronization or migration task. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n99m9jx822k****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. This is a global parameter that does not need to be specified for this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The password of the shard in a MongoDB sharded cluster instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available and required only when the source database instance is a MongoDB sharded cluster instance.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>ModifyAccount</b> is set to <b>true</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DTStest****</para>
        /// </summary>
        [NameInMap("ShardPassword")]
        [Validation(Required=false)]
        public string ShardPassword { get; set; }

        /// <summary>
        /// <para>The account of the shard in a MongoDB sharded cluster instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("ShardUsername")]
        [Validation(Required=false)]
        public string ShardUsername { get; set; }

    }

}
