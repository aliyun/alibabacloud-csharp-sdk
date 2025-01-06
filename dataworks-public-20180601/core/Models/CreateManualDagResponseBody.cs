// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class CreateManualDagResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2d9ce-38ef-4923-baf6-391a7e656</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReturnCode")]
        [Validation(Required=false)]
        public string ReturnCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ReturnErrorSolution")]
        [Validation(Required=false)]
        public string ReturnErrorSolution { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ReturnMessage")]
        [Validation(Required=false)]
        public string ReturnMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1244311235</para>
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public long? ReturnValue { get; set; }

    }

}
