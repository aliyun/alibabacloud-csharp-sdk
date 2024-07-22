// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListConversationsRequest : TeaModel {
        [NameInMap("BeginTimeLeftRange")]
        [Validation(Required=false)]
        public long? BeginTimeLeftRange { get; set; }

        [NameInMap("BeginTimeRightRange")]
        [Validation(Required=false)]
        public long? BeginTimeRightRange { get; set; }

        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsSandBox")]
        [Validation(Required=false)]
        public string IsSandBox { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public long? Result { get; set; }

        [NameInMap("RoundsLeftRange")]
        [Validation(Required=false)]
        public int? RoundsLeftRange { get; set; }

        [NameInMap("RoundsRightRange")]
        [Validation(Required=false)]
        public int? RoundsRightRange { get; set; }

    }

}
