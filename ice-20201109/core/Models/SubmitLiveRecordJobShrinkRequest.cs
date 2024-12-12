// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveRecordJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the recording job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live stream record 1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/imsnotify">https://example.com/imsnotify</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The storage address of the recording.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordOutput")]
        [Validation(Required=false)]
        public string RecordOutputShrink { get; set; }

        /// <summary>
        /// <para>The URL of the live stream.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public string StreamInputShrink { get; set; }

        /// <summary>
        /// <para>The ID of the recording template.</para>
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
