// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class GetDataServiceContextUpdateEventResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;TotalCount\&quot;: 0, \&quot;CalcEngines\&quot;: []}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8754EE08-4AA2-5F77-ADD7-754DBBDA9F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
