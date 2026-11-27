// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyAppRecordTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Application ID. Create and query through the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Recording template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordTemplate")]
        [Validation(Required=false)]
        public string RecordTemplateShrink { get; set; }

    }

}
