// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeNameListPageListRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("updateBeginTime")]
        [Validation(Required=false)]
        public long? UpdateBeginTime { get; set; }

        [NameInMap("updateEndTime")]
        [Validation(Required=false)]
        public long? UpdateEndTime { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("variableId")]
        [Validation(Required=false)]
        public long? VariableId { get; set; }

    }

}
