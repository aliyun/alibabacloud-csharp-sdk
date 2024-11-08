// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-cd03crwys0lrls0</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
