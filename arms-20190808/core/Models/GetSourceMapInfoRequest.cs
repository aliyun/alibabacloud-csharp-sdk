// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSourceMapInfoRequest : TeaModel {
        /// <summary>
        /// The order in which the files are sorted. Valid values:
        /// 
        /// *   true: ascending order
        /// *   false: descending order
        /// </summary>
        [NameInMap("AscendingSequence")]
        [Validation(Required=false)]
        public bool? AscendingSequence { get; set; }

        /// <summary>
        /// The version of the SourceMap file.
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// The ID of the SourceMap file.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        /// <summary>
        /// The keyword in the file name. The files are searched by keyword.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The criterion by which the files are sorted. Valid values:
        /// 
        /// *   version: The files are sorted by version.
        /// *   uploadTime: The files are sorted by upload time.
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
