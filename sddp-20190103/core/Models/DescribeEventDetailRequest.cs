// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventDetailRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the anomalous activity.</para>
        /// <remarks>
        /// <para>To query the details of a single anomalous activity, provide the unique ID of the anomalous activity. You can call the <b>DescribeEvents</b> operation to obtain the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13456723343</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
