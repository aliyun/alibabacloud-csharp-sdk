// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetDemonstrationForCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>story</para>
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

    }

}
