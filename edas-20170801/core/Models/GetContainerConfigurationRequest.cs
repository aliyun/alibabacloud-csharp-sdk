// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetContainerConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-4f92-**************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the instance group.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is specified, this operation queries the Tomcat configuration of the instance group.</description></item>
        /// <item><description>If this parameter is not specified, this operation queries the Tomcat configuration of the application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8123db90-880f-**************</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

    }

}
