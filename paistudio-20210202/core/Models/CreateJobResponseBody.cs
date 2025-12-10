// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class CreateJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>job-jcs4mmyangk7r2zdqz</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>85082123-2A3F-52E7-B27A-F04700B82FFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
