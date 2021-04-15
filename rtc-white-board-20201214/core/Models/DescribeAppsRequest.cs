/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class DescribeAppsRequest : TeaModel {
        /// <summary>
        /// 白板应用唯一标识符，默认查询所有应用ID
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// 白板应用状态，默认查询所有状态。（取值：1:启用，2:停用）
        /// </summary>
        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public long? AppStatus { get; set; }

        /// <summary>
        /// 第几页，默认查询第1页。
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// 每页显示个数，默认为10。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
