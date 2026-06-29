// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class Workforce : TeaModel {
        /// <summary>
        /// <para>Node name.<br>Valid values include: SAMPLING, CHECK, MARK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>List of user information</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<SimpleUser> Users { get; set; }

        /// <summary>
        /// <para>Node ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("WorkNodeId")]
        [Validation(Required=false)]
        public int? WorkNodeId { get; set; }

    }

}
