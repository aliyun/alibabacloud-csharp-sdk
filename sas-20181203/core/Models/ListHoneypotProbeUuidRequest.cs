// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotProbeUuidRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the management node.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListHoneypotNode~~">ListHoneypotNode</a> operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a882e590-b87b-45a6-87b9-d0a3e5a0****</para>
        /// </summary>
        [NameInMap("ControlNodeId")]
        [Validation(Required=false)]
        public string ControlNodeId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and the response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The type of the probe. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>host_probe</b>: host probe</description></item>
        /// <item><description><b>vpc_black_hole_probe</b>: virtual private cloud (VPC) probe</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>host_probe</para>
        /// </summary>
        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

    }

}
