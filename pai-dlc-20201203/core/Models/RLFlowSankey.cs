// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowSankey : TeaModel {
        /// <summary>
        /// <para>The five columns of the main chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;traj&quot;,&quot;Label&quot;:&quot;Generated trajectory&quot;,&quot;Count&quot;:96}]</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<RLFlowSankeyColumn> Columns { get; set; }

        /// <summary>
        /// <para>The outflow edges of each column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;From&quot;:&quot;run&quot;,&quot;FromIdx&quot;:1,&quot;Label&quot;:&quot;Not started&quot;,&quot;Count&quot;:0}]</para>
        /// </summary>
        [NameInMap("Exits")]
        [Validation(Required=false)]
        public List<RLFlowSankeyExit> Exits { get; set; }

    }

}
