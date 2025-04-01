// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class ReportBizAlertInfoRequest : TeaModel {
        [NameInMap("AlertDescription")]
        [Validation(Required=false)]
        public string AlertDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertDetail")]
        [Validation(Required=false)]
        public string AlertDetail { get; set; }

        [NameInMap("AlertGrade")]
        [Validation(Required=false)]
        public string AlertGrade { get; set; }

        [NameInMap("AlertLabels")]
        [Validation(Required=false)]
        public string AlertLabels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertScene")]
        [Validation(Required=false)]
        public string AlertScene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertToken")]
        [Validation(Required=false)]
        public string AlertToken { get; set; }

        [NameInMap("AlertUid")]
        [Validation(Required=false)]
        public List<long?> AlertUid { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
