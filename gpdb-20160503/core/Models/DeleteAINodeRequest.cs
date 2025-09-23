// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DeleteAINodeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AINodeNum")]
        [Validation(Required=false)]
        public int? AINodeNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aipool-xxxx</para>
        /// </summary>
        [NameInMap("AINodePoolId")]
        [Validation(Required=false)]
        public string AINodePoolId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

    }

}
