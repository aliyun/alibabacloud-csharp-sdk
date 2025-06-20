// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeVscResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the compute node in which the VSC resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-kvw44e6dn04</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2k3rqlvv6ytq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The VSC status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Normal</description></item>
        /// <item><description>Deleting</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The VSC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsc-001</para>
        /// </summary>
        [NameInMap("VscId")]
        [Validation(Required=false)]
        public string VscId { get; set; }

        /// <summary>
        /// <para>The custom name of the VSC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("VscName")]
        [Validation(Required=false)]
        public string VscName { get; set; }

        /// <summary>
        /// <para>The VSC type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("VscType")]
        [Validation(Required=false)]
        public string VscType { get; set; }

    }

}
