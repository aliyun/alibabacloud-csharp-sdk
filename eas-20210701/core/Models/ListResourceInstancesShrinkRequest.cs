// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListResourceInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Filters instances by billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PrePaid: subscription.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>A keyword for the search. You can search by instance ID or IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.224.xx.xx</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.224.xx.xx</para>
        /// </summary>
        [NameInMap("InstanceIP")]
        [Validation(Required=false)]
        public string InstanceIP { get; set; }

        /// <summary>
        /// <para>Filter by instance ID. For more information, see <a href="https://help.aliyun.com/document_detail/412129.html">ListResourceInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1jd6x3uots****a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Filter by instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-xxxx***</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The status of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>Filter by label.</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string LabelShrink { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances to return on each page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>J</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
