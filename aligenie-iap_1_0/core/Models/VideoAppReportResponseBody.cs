// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class VideoAppReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned error code. <c>0</c> indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        /// <summary>
        /// <para>The returned error message. This field is not returned if the operation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求异常</para>
        /// </summary>
        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        /// <summary>
        /// <para>The returned invocation result.</para>
        /// <list type="bullet">
        /// <item><description>true indicates success.</description></item>
        /// <item><description>false indicates failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public bool? RetValue { get; set; }

    }

}
