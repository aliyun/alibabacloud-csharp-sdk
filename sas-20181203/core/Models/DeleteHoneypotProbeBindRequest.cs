// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteHoneypotProbeBindRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the bound service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa20815f-f0f3-4e3b-8e13-55771742****</para>
        /// </summary>
        [NameInMap("BindId")]
        [Validation(Required=false)]
        public string BindId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The probe ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListHoneypotProbe~~">ListHoneypotProbe</a> operation to query the IDs of probes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aa234650-cfcf-4e25-b61f-c58f603f****</para>
        /// </summary>
        [NameInMap("ProbeId")]
        [Validation(Required=false)]
        public string ProbeId { get; set; }

    }

}
