// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceSignedUrlRequest : TeaModel {
        /// <summary>
        /// <para>The period of time for which the URL expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43200</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the VPC connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Internal")]
        [Validation(Required=false)]
        public bool? Internal { get; set; }

        /// <summary>
        /// <para>The page type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>webview</description></item>
        /// <item><description>monitor</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>webview</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
