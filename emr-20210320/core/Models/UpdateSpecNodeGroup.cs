// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateSpecNodeGroup : TeaModel {
        /// <summary>
        /// <para>新实例类型。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g7.xlarge</para>
        /// </summary>
        [NameInMap("NewInstanceType")]
        [Validation(Required=false)]
        public string NewInstanceType { get; set; }

        /// <summary>
        /// <para>节点组ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

    }

}
