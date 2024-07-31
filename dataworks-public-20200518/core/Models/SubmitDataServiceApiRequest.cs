// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SubmitDataServiceApiRequest : TeaModel {
        /// <summary>
        /// The API ID. You can call the [ListDataServiceApis](~~ListDataServiceApis~~) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the workspace ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the DataWorks console. Find your workspace and go to the [DataService Studio](https://ds-cn-shanghai.data.aliyun.com/) page. On the DataService Studio page, click the logon username in the upper-right corner and click User Info in the Menu section.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
