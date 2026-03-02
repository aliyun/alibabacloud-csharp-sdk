// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StreamingResourceSetting : TeaModel {
        /// <summary>
        /// <para>The resource parameters in basic mode.</para>
        /// </summary>
        [NameInMap("basicResourceSetting")]
        [Validation(Required=false)]
        public BasicResourceSetting BasicResourceSetting { get; set; }

        /// <summary>
        /// <para>The resource parameters in expert mode.</para>
        /// </summary>
        [NameInMap("expertResourceSetting")]
        [Validation(Required=false)]
        public ExpertResourceSetting ExpertResourceSetting { get; set; }

        /// <summary>
        /// <para>The resource configuration mode used by a deployment that runs in streaming mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EXPERT</description></item>
        /// <item><description>BASIC</description></item>
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
