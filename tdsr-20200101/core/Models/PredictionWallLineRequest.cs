// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class PredictionWallLineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>160</para>
        /// </summary>
        [NameInMap("CameraHeight")]
        [Validation(Required=false)]
        public long? CameraHeight { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyundoc.com/****.jpg">https://www.aliyundoc.com/****.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
