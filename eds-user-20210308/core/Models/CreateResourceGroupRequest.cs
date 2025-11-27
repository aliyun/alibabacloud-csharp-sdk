// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateResourceGroupRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsResourceGroupWithOfficeSite")]
        [Validation(Required=false)]
        public long? IsResourceGroupWithOfficeSite { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> Set the value to AliyunConsole.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not publicly available in other platforms.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunConsole</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
