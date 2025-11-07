// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeOssStatusRequest : TeaModel {
        /// <summary>
        /// <para>Service code:</para>
        /// <list type="bullet">
        /// <item><description>antcloudauth: Financial-grade real-person authentication</description></item>
        /// <item><description>cloudauthst (discontinued): Enhanced real-person authentication</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
