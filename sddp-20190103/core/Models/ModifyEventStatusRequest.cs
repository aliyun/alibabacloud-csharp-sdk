// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyEventStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enhance the detection of anomalous events. If you enhance the detection of anomalous events, the detection accuracy and the rate of triggering alerts for anomalous events are improved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Backed")]
        [Validation(Required=false)]
        public bool? Backed { get; set; }

        /// <summary>
        /// <para>The reason why the anomalous event is handled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Anomaly confirmed</para>
        /// </summary>
        [NameInMap("DealReason")]
        [Validation(Required=false)]
        public string DealReason { get; set; }

        /// <summary>
        /// <para>The ID of the anomalous event.</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeEvents</b> operation to query the ID of the anomalous event.</para>
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
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The method to handle the anomalous event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: marks the anomalous event as a false positive.</description></item>
        /// <item><description><b>2</b>: confirms and handles the anomalous event.</description></item>
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
