// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("GmtFailureTime")]
        [Validation(Required=false)]
        public string GmtFailureTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dsw-5bk19******n97w</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceStartFailed</para>
        /// </summary>
        [NameInMap("ProblemCategory")]
        [Validation(Required=false)]
        public string ProblemCategory { get; set; }

    }

}
