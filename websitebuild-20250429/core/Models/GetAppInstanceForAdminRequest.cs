// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppInstanceForAdminRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery receipt. The delivery receipt ID is the value of the BizId parameter that is returned when you call the SendSms or SendBatchSms operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Wildcard domain names are supported. You can use the wildcard character asterisk (\*) to specify a wildcard domain name.</description></item>
        /// </list>
        /// <para>For example, you can enter \*.baidu.com to specify the domain name baidu.com.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yjdw.bpu.edu.cn-waf</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}
