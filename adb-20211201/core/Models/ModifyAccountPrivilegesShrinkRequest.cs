// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyAccountPrivilegesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The list of granted permissions.</para>
        /// </summary>
        [NameInMap("AccountPrivileges")]
        [Validation(Required=false)]
        public string AccountPrivilegesShrink { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The cluster ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The cluster ID of the Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1k5p066e1a****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("PromqlInsertPrivileges")]
        [Validation(Required=false)]
        public string PromqlInsertPrivilegesShrink { get; set; }

        [NameInMap("PromqlSelectNodePercentage")]
        [Validation(Required=false)]
        public double? PromqlSelectNodePercentage { get; set; }

        [NameInMap("PromqlSelectPrivileges")]
        [Validation(Required=false)]
        public string PromqlSelectPrivilegesShrink { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
