// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the template to be deleted. To obtain the template ID, log on to the <a href="https://ice.console.aliyun.com/live-processing/template/list/record">Intelligent Media Services (IMS) console</a>, choose Real-time Media Processing &gt; Template Management, and then click the Recording tab. Alternatively, find the ID from the response parameters of the <a href="https://help.aliyun.com/document_detail/448213.html">CreateLiveRecordTemplate</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
