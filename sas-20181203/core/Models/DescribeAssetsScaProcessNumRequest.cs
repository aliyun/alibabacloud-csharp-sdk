// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsScaProcessNumRequest : TeaModel {
        /// <summary>
        /// <para>The type of the application process. Default value: java. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>java</b></description></item>
        /// <item><description><b>php</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
