// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class HTTPTrigger : TeaModel {
        /// <summary>
        /// <para>The public domain address. You can access HTTP triggers over the Internet by using HTTP or HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://svc-func-xxxxxxxx.cn-hangzhou.fcapp.run">https://svc-func-xxxxxxxx.cn-hangzhou.fcapp.run</a></para>
        /// </summary>
        [NameInMap("urlInternet")]
        [Validation(Required=false)]
        public string UrlInternet { get; set; }

        /// <summary>
        /// <para>The private endpoint. In a VPC, you can access HTTP triggers by using HTTP or HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://svc-func-xxxxxxxx.cn-hangzhou-vpc.fcapp.run">https://svc-func-xxxxxxxx.cn-hangzhou-vpc.fcapp.run</a></para>
        /// </summary>
        [NameInMap("urlIntranet")]
        [Validation(Required=false)]
        public string UrlIntranet { get; set; }

    }

}
