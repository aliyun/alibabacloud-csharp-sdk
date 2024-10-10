// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceListRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return custom namespaces. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system returns custom namespaces.</description></item>
        /// <item><description><b>false</b>: The system does not return custom namespaces.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ContainCustom")]
        [Validation(Required=false)]
        public bool? ContainCustom { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude hybrid cloud namespaces from the result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system excludes hybrid cloud namespaces from the result.</description></item>
        /// <item><description><b>false</b>: The system does not exclude hybrid cloud namespaces from the result.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HybridCloudExclude")]
        [Validation(Required=false)]
        public bool? HybridCloudExclude { get; set; }

    }

}
