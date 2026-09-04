// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDiagnosisItemsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-v0h14zdee000mimee</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The supported request language. Default value: the browser request language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English</description></item>
        /// <item><description>zh: Simplified Chinese</description></item>
        /// <item><description>zt: Traditional Chinese</description></item>
        /// <item><description>es: Spanish</description></item>
        /// <item><description>fr: French</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The diagnostic item level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BASIC: basic inspection item (free).</description></item>
        /// <item><description>ADVANCED: advanced inspection item (consumes billable tokens).</description></item>
        /// </list>
        /// <para>If this parameter is not specified, diagnostic items of all levels are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

    }

}
