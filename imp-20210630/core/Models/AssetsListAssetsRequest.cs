// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class AssetsListAssetsRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Optional. Used to specify a subset of fields that should be
        /// returned by a get operation or modified by an update operation.
        /// </summary>
        [NameInMap("FieldMask")]
        [Validation(Required=false)]
        public string FieldMask { get; set; }

        /// <summary>
        /// 每页显示个数，最大支持20，参数为空默认显示个数为10。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页Token Optional.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// 订阅Topic
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
