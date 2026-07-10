// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeOssStatusRequest : TeaModel {
        /// <summary>
        /// <para>The service code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>antcloudauth: Chinese financial-grade ID Verification.</description></item>
        /// <item><description>cloudauthst (discontinued): ID Verification Enhanced Edition.</description></item>
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
