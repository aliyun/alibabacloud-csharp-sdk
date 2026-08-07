// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ManualTriggerMaskingProcessRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data masking task, represented as a number.</para>
        /// <para><note>The data masking task ID is represented by a string of characters. You can call the DescribeDataMaskingTasks operation to obtain the ID.</note></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: zh_cn. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese.</description></item>
        /// <item><description><b>en_us</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
