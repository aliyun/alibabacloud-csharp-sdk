// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetDemonstrationForCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <para>The demonstration scenario.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>story</b></para>
        /// </description></item>
        /// <item><description><para><b>interaction</b></para>
        /// </description></item>
        /// <item><description><para><b>navigation</b></para>
        /// </description></item>
        /// </list>
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
