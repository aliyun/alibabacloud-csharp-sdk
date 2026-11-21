// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateServiceRecordRequest : TeaModel {
        /// <summary>
        /// <para>The content of the entry. The value is a JSON string. The format varies based on the recordType.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;project&quot;: &quot;proj-xtrace-16c988dcfe21fcb73c5e6f234927d998-cn-hangzhou&quot;,
        ///   &quot;storeName&quot;: &quot;app-biz-log&quot;,
        ///   &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
        ///   &quot;bindType&quot;: &quot;logstore&quot;,
        ///   &quot;traceIdRelateField&quot;: &quot;&quot;
        /// }</para>
        /// </summary>
        [NameInMap("recordContent")]
        [Validation(Required=false)]
        public string RecordContent { get; set; }

        /// <summary>
        /// <para>The type of the association entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>logCorrelation: Application log association.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logCorrelation</para>
        /// </summary>
        [NameInMap("recordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

    }

}
