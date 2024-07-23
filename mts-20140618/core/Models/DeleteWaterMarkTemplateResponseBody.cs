// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class DeleteWaterMarkTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>030E2671-806A-52AF-A93C-DA8E308603A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the deleted watermark template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3780bd69b2b74540bc7b1096f564****</para>
        /// </summary>
        [NameInMap("WaterMarkTemplateId")]
        [Validation(Required=false)]
        public string WaterMarkTemplateId { get; set; }

    }

}
