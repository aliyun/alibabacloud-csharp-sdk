// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>The log type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROVIDER</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROVIDER</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
