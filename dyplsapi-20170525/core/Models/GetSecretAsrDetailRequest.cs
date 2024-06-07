// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetSecretAsrDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the call record.
        /// 
        /// You can log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) and view **Call Record ID** on the **Call Record Query** page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// The call initiation time in the call record.
        /// 
        /// You can log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account). View **Call Initiated At** on the **Call Record Query** page, or view the call_time field in the Call Detail Record (CDR) receipt.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public string CallTime { get; set; }

        /// <summary>
        /// The key of the phone number pool.
        /// 
        /// You can log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) and view the key of the phone number pool on the **Number Pool Management** page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

    }

}
