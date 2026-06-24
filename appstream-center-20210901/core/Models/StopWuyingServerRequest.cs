// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class StopWuyingServerRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly restart the workstation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: forcibly restart</description></item>
        /// <item><description>False: do not forcibly restart.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The list of workstation IDs.</para>
        /// </summary>
        [NameInMap("WuyingServerIdList")]
        [Validation(Required=false)]
        public List<string> WuyingServerIdList { get; set; }

    }

}
