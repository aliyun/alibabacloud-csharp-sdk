// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetTokenRequest : TeaModel {
        /// <summary>
        /// <para>The expiration duration of the sharing link, in seconds. Default value: 604800 seconds. Minimum value: 0 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the training job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>traincclrt205dcs</para>
        /// </summary>
        [NameInMap("TrainingJobId")]
        [Validation(Required=false)]
        public string TrainingJobId { get; set; }

    }

}
