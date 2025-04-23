// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateParameterSetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pts-3b6cb9fa4751afff89a4b73779e0d</para>
        /// </summary>
        [NameInMap("parameterSetId")]
        [Validation(Required=false)]
        public string ParameterSetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7FA0FF4A-ABD4-54F6-BEAC-B4273EBA10A2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
