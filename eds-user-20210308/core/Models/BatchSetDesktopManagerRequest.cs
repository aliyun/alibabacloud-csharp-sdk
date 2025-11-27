// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class BatchSetDesktopManagerRequest : TeaModel {
        /// <summary>
        /// <para>Whether the convenience account has the local administrator permissions on cloud computers.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no</description></item>
        /// <item><description>1 (default): yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDesktopManager")]
        [Validation(Required=false)]
        public string IsDesktopManager { get; set; }

        /// <summary>
        /// <para>The convenience accounts.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
