// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER_DEFINED:2001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The account ID of the owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Detailed configuration Spec code of the rule template. For more information, see <a href="~2963394~">Data quality Spec configuration description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;assertion&quot;: &quot;anomaly detection fro id_not_null_cnt&quot;,
        ///     &quot;id_not_null_cnt&quot;: {
        ///         &quot;query&quot;: &quot;SELECT COUNT(*) AS cnt FROM ${tableName} WHERE dt = \&quot;$[yyyymmdd-1]\&quot;;&quot;
        ///     },
        ///     &quot;identity&quot;: &quot;819cf1f8-29be-4f94-a9d0-c5c06c0c3d2a&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
