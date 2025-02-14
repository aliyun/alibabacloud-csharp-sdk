// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUserVpcRequest : TeaModel {
        /// <summary>
        /// <para>Region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("K8sRegionId")]
        [Validation(Required=false)]
        public string K8sRegionId { get; set; }

    }

}
