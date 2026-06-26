// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateResourceGroupRequest : TeaModel {
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        [NameInMap("EnableAliyunResourceGroup")]
        [Validation(Required=false)]
        public bool? EnableAliyunResourceGroup { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsResourceGroupWithOfficeSite")]
        [Validation(Required=false)]
        public long? IsResourceGroupWithOfficeSite { get; set; }

        /// <summary>
        /// <para>For WUYING Workspace Enterprise Edition, set this parameter to <c>AliyunConsole</c>. Other platforms are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunConsole</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceClassification")]
        [Validation(Required=false)]
        public string ResourceClassification { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>部门A资源组</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
