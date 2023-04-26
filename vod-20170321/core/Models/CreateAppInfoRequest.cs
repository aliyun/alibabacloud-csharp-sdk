// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAppInfoRequest : TeaModel {
        /// <summary>
        /// Creates an application.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// ## Common errors
        /// 
        /// The following table describes the common errors that this operation can return. 
        /// 
        /// | Error code | Error message | HTTP status code | Description |
        /// | ---------- | ------------- | ---------------- | ----------- |
        /// | OperationDenied.NotOpenAppService | The app service is not open. | 403 | The error message returned because the multi-application service has not been activated. |
        /// | Forbidden.OperateApp | User not authorized to operate app. | 403 | The error message returned because you are not authorized to manage the application. |
        /// | AlreadyExist.AppName | The specified AppName has already exist. | 409 | The error message returned because the name of the application already exists. |
        /// | LimitExceeded.AppCount | App Count has exceeded 10. | 400 | The error message returned because the number of applications that can be created exceeds the upper limit. |
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
