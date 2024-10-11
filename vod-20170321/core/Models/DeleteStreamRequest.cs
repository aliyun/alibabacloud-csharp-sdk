// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteStreamRequest : TeaModel {
        /// <summary>
        /// <para>The job IDs for deleting media streams.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,). A maximum of 20 IDs can be specified for one video.</description></item>
        /// <item><description>You can obtain job IDs from the PlayInfo parameter that is returned after you call the <a href="https://help.aliyun.com/document_detail/56124.html">GetPlayInfo</a> operation. Each media stream has a unique job ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35eb4dbda18c49cc0025df374b46****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The ID of the video.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95948ddba24446b6aed5db985e78****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
