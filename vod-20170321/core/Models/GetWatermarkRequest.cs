// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the watermark template to query. Only a single watermark template ID is supported. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~AddWatermark~~">AddWatermark</a> operation to add a watermark template. The ID is returned.</description></item>
        /// <item><description>Call the <a href="~~ListWatermark~~">ListWatermark</a> operation to query the list of watermark templates. The ID is returned.</description></item>
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
