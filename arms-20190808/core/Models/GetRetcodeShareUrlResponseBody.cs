// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeShareUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01FF8DD9-A09C-47A1-895A-B6E321******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The share URL of the application monitored by Browser Monitoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://arms-daily.console.aliyun.com:8080/shareapi/retcode.json?login_arms_t3h_token=XXXxxx&action=RetcodeAction&eventSubmitDoGetData=1">http://arms-daily.console.aliyun.com:8080/shareapi/retcode.json?login_arms_t3h_token=XXXxxx&amp;action=RetcodeAction&amp;eventSubmitDoGetData=1</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
