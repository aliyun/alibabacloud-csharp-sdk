// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyBlackListStrategyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The blacklist rule.</para>
        /// </summary>
        [NameInMap("BlackListStrategy")]
        [Validation(Required=false)]
        public string BlackListStrategyShrink { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
