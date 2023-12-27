// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSubTaskRequest : TeaModel {
        /// <summary>
        /// [](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex)
        /// 
        /// **
        /// 
        /// ****
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// *   ****
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public string ReportIds { get; set; }

    }

}
