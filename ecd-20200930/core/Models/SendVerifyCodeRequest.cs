// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SendVerifyCodeRequest : TeaModel {
        /// <summary>
        /// The information that is required to send the verification code, in JSON format. When you verify the CEN instance of another Alibaba Cloud account, you must provide the ID of the CEN instance and the ID of the Alibaba Cloud account to which the instance belongs.
        /// 
        /// *   CenId: the ID of the CEN instance.
        /// *   CenOwnerId: the ID of the Alibaba Cloud account to which the CEN instance belongs.
        /// 
        /// >  If you own the CEN instance, skip this parameter. If you do not own the CEN instance, specify the ID of the Alibaba Cloud account that owns the CEN instance.
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The action that you want to perform by using the verification code.
        /// 
        /// Valid value:
        /// 
        /// *   eds_cenID_securityverification: Use the verification code to verify the CEN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VerifyCodeAction")]
        [Validation(Required=false)]
        public string VerifyCodeAction { get; set; }

    }

}
