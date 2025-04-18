// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetVLExtractionResultRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>taskID.</para>
        /// </description></item>
        /// <item><description><para>The taskId is obtained from the interfaces SubmitVLExtractionTaskAdvance and SubmitVLExtractionTask.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1436b6f5-ddea-4308-9d1c-60939e5d5ea8</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
