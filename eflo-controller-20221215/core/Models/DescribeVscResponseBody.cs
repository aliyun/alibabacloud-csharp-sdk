// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeVscResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>e01-cn-kvw44e6dn04</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aek2k3rqlvv6ytq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>VscId</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsc-001</para>
        /// </summary>
        [NameInMap("VscId")]
        [Validation(Required=false)]
        public string VscId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("VscName")]
        [Validation(Required=false)]
        public string VscName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("VscType")]
        [Validation(Required=false)]
        public string VscType { get; set; }

    }

}
