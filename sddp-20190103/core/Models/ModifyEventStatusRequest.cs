// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyEventStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enhance the detection of the anomalous activity. Enhancing detection improves accuracy and increases the alert rate for anomalous activities.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Backed")]
        [Validation(Required=false)]
        public bool? Backed { get; set; }

        /// <summary>
        /// <para>The reason for handling the anomalous activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Confirmed as violation</para>
        /// </summary>
        [NameInMap("DealReason")]
        [Validation(Required=false)]
        public string DealReason { get; set; }

        /// <summary>
        /// <para>The unique ID of the anomalous activity.</para>
        /// <remarks>
        /// <para>To handle an anomalous activity, you must provide its unique ID. You can obtain this ID by calling the <b>DescribeEvents</b> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The operation to perform on the anomalous activity.</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Mark as false positive.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Confirm and handle the anomalous activity.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
