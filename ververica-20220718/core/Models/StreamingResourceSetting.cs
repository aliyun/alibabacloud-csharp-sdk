// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StreamingResourceSetting : TeaModel {
        [NameInMap("basicResourceSetting")]
        [Validation(Required=false)]
        public BasicResourceSetting BasicResourceSetting { get; set; }

        [NameInMap("expertResourceSetting")]
        [Validation(Required=false)]
        public ExpertResourceSetting ExpertResourceSetting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXPERT</para>
        /// </summary>
        [NameInMap("resourceSettingMode")]
        [Validation(Required=false)]
        public string ResourceSettingMode { get; set; }

    }

}
