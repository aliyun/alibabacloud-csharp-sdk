// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StreamingResourceSetting : TeaModel {
        /// <summary>
        /// <para>The resource settings for basic mode.</para>
        /// </summary>
        [NameInMap("basicResourceSetting")]
        [Validation(Required=false)]
        public BasicResourceSetting BasicResourceSetting { get; set; }

        /// <summary>
        /// <para>The resource settings for expert mode.</para>
        /// </summary>
        [NameInMap("expertResourceSetting")]
        [Validation(Required=false)]
        public ExpertResourceSetting ExpertResourceSetting { get; set; }

        /// <summary>
        /// <para>The resource mode used in stream mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EXPERT: expert mode.</description></item>
        /// <item><description>BASIC: basic mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EXPERT</para>
        /// </summary>
        [NameInMap("resourceSettingMode")]
        [Validation(Required=false)]
        public string ResourceSettingMode { get; set; }

    }

}
