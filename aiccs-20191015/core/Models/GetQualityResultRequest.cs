// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityResultRequest : TeaModel {
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<long?> GroupIds { get; set; }

        [NameInMap("HitStatus")]
        [Validation(Required=false)]
        public int? HitStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public List<long?> ProjectIds { get; set; }

        [NameInMap("QualityRuleIds")]
        [Validation(Required=false)]
        public List<long?> QualityRuleIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TouchEndTime")]
        [Validation(Required=false)]
        public string TouchEndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TouchStartTime")]
        [Validation(Required=false)]
        public string TouchStartTime { get; set; }

    }

}
