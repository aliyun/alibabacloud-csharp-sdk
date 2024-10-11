// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetDefaultWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the watermark template. You can specify only one watermark template ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Obtain the watermark template ID from the response to the <a href="~~AddWatermark~~">AddWatermark</a> operation that you call to create a watermark template.</description></item>
        /// <item><description>Obtain the watermark template ID from the response to the <a href="~~ListWatermark~~">ListWatermark</a> operation that you call to query all watermark templates within your account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9bcc8bfadb843f*****09a2671d0df97</para>
        /// </summary>
        [NameInMap("WatermarkId")]
        [Validation(Required=false)]
        public string WatermarkId { get; set; }

    }

}
