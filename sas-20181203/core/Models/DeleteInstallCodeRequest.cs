// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteInstallCodeRequest : TeaModel {
        /// <summary>
        /// The installation command.
        /// 
        /// >  You can call the [DescribeInstallCodes](~~DescribeInstallCodes~~) operation to query installation commands.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CaptchaCode")]
        [Validation(Required=false)]
        public string CaptchaCode { get; set; }

    }

}
