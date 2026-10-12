// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102E8E24-0387-531D-8A75-1C0AE7DD03E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the data source was updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes.</description></item>
        /// <item><description>false: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
