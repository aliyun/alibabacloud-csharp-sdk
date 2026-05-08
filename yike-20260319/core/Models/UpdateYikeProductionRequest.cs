// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class UpdateYikeProductionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd_12334**</para>
        /// </summary>
        [NameInMap("ProductionId")]
        [Validation(Required=false)]
        public string ProductionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
