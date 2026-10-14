// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageInfosRequest : TeaModel {
        /// <summary>
        /// <para>The operating system type. Only a single type can be specified. If this parameter is not specified, all types are queried.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Linux</para>
        /// </description></item>
        /// <item><description><para>windows</para>
        /// </description></item>
        /// </list>
        /// <para>In practice, passing linux or Linux may return an empty list, whereas omitting this parameter can return images with an OSType of linux. Verify the actual results before relying on this filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

    }

}
