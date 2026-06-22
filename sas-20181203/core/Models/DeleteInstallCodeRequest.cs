// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteInstallCodeRequest : TeaModel {
        /// <summary>
        /// <para>The installation code.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeInstallCodes~~">DescribeInstallCodes</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1q****</para>
        /// </summary>
        [NameInMap("CaptchaCode")]
        [Validation(Required=false)]
        public string CaptchaCode { get; set; }

    }

}
