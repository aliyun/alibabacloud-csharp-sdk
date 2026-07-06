// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GenerateCredentialReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBCCA90A-A1F0-4B16-B355-692247197805</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The generation status of the user credential report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>STARTED: The system starts to generate the user credential report.</para>
        /// </description></item>
        /// <item><description><para>INPROGRESS: The user credential report is being generated.</para>
        /// </description></item>
        /// <item><description><para>COMPLETED: The user credential report is generated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STARTED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
