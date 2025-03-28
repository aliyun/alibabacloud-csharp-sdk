// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionMetaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the distributed change tracking instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsbr4m9luv2******</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the change tracking instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the consumer group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>z38m91gg2******</para>
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// <para>The IDs of all subtasks in the distributed change tracking task. Separate multiple subtask IDs with commas (,).</para>
        /// <remarks>
        /// <para> You must specify at least one of the SubMigrationJobIds and <b>Topics</b> parameters. We recommend that you specify the SubMigrationJobIds parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>z38m91gg2******</para>
        /// </summary>
        [NameInMap("SubMigrationJobIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> SubMigrationJobIds { get; set; }

        /// <summary>
        /// <para>The topics of all subtasks in the distributed change tracking task. Separate multiple topics with commas (,).</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>SubMigrationJobIds</b> and Topics parameters. We recommend that you specify the <b>SubMigrationJobIds</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn_hangzhou_rm_bp1n0x0x5tz******_dtstestdata_version2</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public Dictionary<string, object> Topics { get; set; }

    }

}
