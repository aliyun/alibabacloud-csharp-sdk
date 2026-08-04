// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetJiangSuTelecomDataRequest : TeaModel {
        /// <summary>
        /// <para>Date in the format yyyy-MM-dd. This refers to the data timestamp when the data becomes available, not the date when the data was generated. Data is always produced on a T+1 basis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-09</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

    }

}
