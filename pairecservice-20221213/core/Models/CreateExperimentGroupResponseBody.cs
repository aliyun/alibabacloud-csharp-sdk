// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateExperimentGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ExperimentGroupId")]
        [Validation(Required=false)]
        public string ExperimentGroupId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A04CB8C0-E74A-5E83-BC61-64D153574EC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
